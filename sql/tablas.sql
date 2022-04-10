use MAYER
go
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
CREATE TABLE NODO
(
	id_lm int primary key identity(1,1)not null, --NODO
	idP_lm int foreign key references STOCK_P(id_p) NULL, --PRODUCTO
	idMP_lm int foreign key references STOCK_MP (id_mp) NULL, --MATERIAL
	cant_lm smallint NOT NULL,
	plazo_lm smallint null --DIAS
);
go
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
AS BEGIN
	SELECT
	id_mp as [id],
	nombre_mp as [Nombre],
	costo_mp as [Costo],
	existencia_mp as [Existencia],
	stockS_mp as [Stock S],
	totalMp as [Total],
	CASE
		WHEN estado_mp=1 THEN 'INSTOCK'
	END AS [Estado]
	FROM STOCK_MP WHERE estado_mp=1
END;
go