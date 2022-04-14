CREATE DATABASE InventarioSYS
go
USE InventarioSYS
go
--||TABLAS DE LA BD
CREATE TABLE STOCK_MP
(
	id_mp int primary key identity(1,1) not null,
	nombre_mp varchar(50) not null,
	costo_mp decimal(5,2) not null,
	existencia_mp int default 0 not null,
	stockS_mp smallint default 0 null,
	totalMp AS (costo_mp * existencia_mp),
	estado_mp bit default 1
);
go
CREATE TABLE [dbo].[NODO]
(
	[id_nodo] [int] IDENTITY(1,1) PRIMARY KEY NOT NULL,
	[nodo_padre] [int] NOT NULL,
	[nodo_hijo] [int] NOT NULL,
	[des_nodo] [varchar](70) NOT NULL,
	[cant_nodo] [int] NOT NULL,
	[t_nodo] [int] NULL,
)
go
CREATE TABLE [dbo].[STOCK_P](
	[id_p] [int] IDENTITY(1,1) PRIMARY KEY NOT NULL,
	[nombre_p] [varchar](50) NOT NULL,
	[costo_p] [decimal](5, 2) NOT NULL,
	[precio_p] [decimal](5, 2) NOT NULL,
	[existencia_p] [smallint] NOT NULL,
	[stock_seguridad] [smallint] NOT NULL,
	[totalInventario]  AS ([precio_p]*[existencia_p]),
	[estado_p] [bit] NULL,
);
go
CREATE TABLE PLAN_MAESTRO
(
	id int identity(1,1) primary key not null,
	Nodo int foreign key references Nodo(id_nodo) not null,
	demanda int not null,
	periodo int not null,
);
go
CREATE TABLE RECEPCION_PROGRAMADA
(
	id int identity(1,1) primary key not null,
	Nodo int foreign key references Nodo(id_nodo) not null,
	periodo int not null,
	cantidad int not null
);
go
----------------------------||STORAGE PROCEDURES
CREATE OR ALTER PROC SP_INSERT_PRODUCT 
(@nombre varchar(50),@costo decimal(5,2),@precio decimal(5,2), @exist smallint, @ss smallint)
AS
BEGIN
	--||LA VARIABLE SS SIGNIFICA STOCK DE SEGURIDAD
	IF NOT EXISTS (SELECT nombre_p FROM STOCK_P where nombre_p = @nombre)
		INSERT INTO STOCK_P (nombre_p,costo_p,precio_p,existencia_p,stock_seguridad) 
			VALUES (@nombre,@costo,@precio,@exist,@ss)
	ELSE
		PRINT 'ERROR'
END;
go
CREATE OR ALTER PROC SP_UPDATE_PRODUCT 
(@Id INT ,@nombre varchar(50),@costo decimal(5,2),@precio decimal(5,2), @exist smallint, @ss smallint)
AS
BEGIN
	--||LA VARIABLE SS SIGNIFICA STOCK DE SEGURIDAD
IF EXISTS (SELECT id_p FROM STOCK_P WHERE id_p = @Id)
	IF NOT EXISTS (SELECT nombre_p FROM STOCK_P where nombre_p = @nombre)
		update STOCK_P set nombre_p =@nombre, costo_p=@costo, precio_p=@precio, existencia_p =@exist, stock_seguridad = @ss  where id_p = @id
	ELSE
		PRINT 'ERROR'
ELSE
	PRINT 'ERROR'
END;
go
CREATE OR ALTER PROC SP_DELETE_PRODUCT
(@Id int)
AS
BEGIN
	IF EXISTS (SELECT id_p FROM STOCK_P where id_p =@Id)
		UPDATE STOCK_P SET estado_p = 0 WHERE id_p = @Id
	ELSE
		PRINT 'ERROR'
END;
go
CREATE OR ALTER PROC SP_VIEW_PRODUCT 
(@dato varchar(max))
AS BEGIN
	SELECT  
		id_p as [Cod],
		nombre_p as [Nombre],
		costo_p as [Costo],
		precio_p as [Precio],
		existencia_p as [Stock],
		stock_seguridad as [Stock S],
		totalInventario as [Total],
		CASE
			WHEN estado_p = 1 THEN 'INSTOCK'
		END AS [Estado]
	FROM STOCK_P where nombre_p like @dato+'%'
	AND estado_p = 1 
END; 
go
--PROCEDIMIENTOS PARA MATERIALES
CREATE OR ALTER PROC SP_INSERT_MATERIAL 
(@nombre varchar(50), @costo decimal(5,2), @exist smallint, @ss smallint)
AS BEGIN
--|| LA VARIABLE SS SIGNIFICA STOCK DE SEGURIDAD
IF NOT EXISTS (SELECT nombre_mp	FROM STOCK_MP where nombre_mp= @nombre)
	INSERT  INTO STOCK_MP (nombre_mp,costo_mp,existencia_mp,stockS_mp) VALUES (@nombre,@costo,@exist,@ss)
ELSE
	PRINT 'ERROR'
END;
go
CREATE OR ALTER PROC SP_UPDATE_MATERIAL(
	@id INT,@nombre varchar(50), @costo decimal(5,2), @exist smallint, @ss smallint
)
AS
BEGIN
	--|| LA VARIABLE SS SIGNIFICA STOCK DE SEGURIDAD
	IF EXISTS (SELECT id_mp FROM STOCK_MP WHERE id_mp=@id)
		IF NOT EXISTS (SELECT nombre_mp	FROM STOCK_MP where nombre_mp= @nombre)
			update STOCK_MP set nombre_mp=@nombre, costo_mp=@costo, existencia_mp=@exist, stockS_mp=@ss where id_mp=@id
		ELSE
			PRINT 'ERROR'
	ELSE
		PRINT 'ERROR'
END;
go
CREATE OR ALTER PROC SP_DELETE_MATERIAL(
	@id INT
)
AS
BEGIN
	--|| LA VARIABLE SS SIGNIFICA STOCK DE SEGURIDAD
	IF EXISTS (SELECT id_mp FROM STOCK_MP WHERE id_mp=@id)
		update STOCK_MP set estado_mp=0 where id_mp=@id
	ELSE
		PRINT 'ERROR'
END;
go
CREATE OR ALTER PROC SP_VIEW_MATERIAL 
(@dato varchar(max))
AS BEGIN
	SELECT
	id_mp as [Cod],
	nombre_mp as [Nombre],
	costo_mp as [Costo],
	existencia_mp as [Stock],
	stockS_mp as [Stock S],
	totalMp as [Total],
	CASE
		WHEN estado_mp=1 THEN 'INSTOCK'
	END AS [Estado]
	FROM STOCK_MP WHERE nombre_mp like @dato + '%' AND estado_mp=1
END;
go
--PROCEDIMIENTOS NODO
CREATE OR ALTER PROC SP_INSERT_NODO 
(@HIJO INT,@Cant INT, @Periodo INT) 
AS 
BEGIN
	DECLARE @NOMBRE VARCHAR(70) = (SELECT nombre_p FROM STOCK_P WHERE id_p = @hijo) + ' ( '+CONVERT(varchar(50),@cant)+' )'

	IF EXISTS (SELECT nodo_hijo FROM NODO WHERE nodo_hijo =@HIJO AND nodo_padre = 0)
		PRINT 'ERROR DUPLICADO'
	ELSE
		INSERT INTO NODO (nodo_padre,nodo_hijo,des_nodo,cant_nodo,t_nodo) VALUES (0,@HIJO,@NOMBRE,@Cant,@Periodo)
END;
go
CREATE OR ALTER PROC SP_SUB_INSERT_NODO 
(@PADRE INT, @HIJO INT, @cant int, @periodo int)
AS BEGIN
	DECLARE @DESC VARCHAR(70) = (SELECT nombre_mp FROM STOCK_MP WHERE id_mp = @HIJO) + ' ( '+CONVERT(varchar(50),@cant)+' ) '
	IF EXISTS (SELECT nodo_hijo FROM NODO WHERE nodo_hijo = @HIJO AND nodo_padre = @HIJO AND des_nodo = @DESC) BEGIN
		PRINT 'ERROR'
	END
	ELSE
		IF (@PADRE = @HIJO)
			PRINT 'ERROR DE DUPLICIDAD DE NODO E INCOERENCIA DEL METODO'
		ELSE
			INSERT INTO NODO (nodo_padre,nodo_hijo,des_nodo,cant_nodo,t_nodo) VALUES (@PADRE,@HIJO,@DESC,@Cant,@Periodo)
END;
go
CREATE OR ALTER PROC SP_UPDATE_NODO
(@Id int, @cant int, @periodo int)
AS BEGIN
IF exists (select id_nodo from NODO where id_nodo = @Id)
	UPDATE NODO SET cant_nodo = @cant, t_nodo =@periodo  WHERE id_nodo = @Id
END
go
CREATE OR ALTER PROC SP_DELETE_NODO
(@Id int, @t bit)
AS BEGIN
	IF (@t = 0) BEGIN
	IF exists (select id_nodo from NODO where id_nodo = @Id)
		DELETE NODO WHERE id_nodo = @Id
	END 
	ELSE IF(@t = 1)BEGIN
		DELETE NODO
	END
END;
go
CREATE OR ALTER PROC SP_VIEW_NODO
AS BEGIN
	SELECT * FROM NODO
END;
go
select * FROM STOCK_P
select * FROM STOCK_MP
SELECT * FROM NODO
SELECT * FROM PLAN_MAESTRO 
