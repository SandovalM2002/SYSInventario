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
AS BEGIN
	SELECT  
		id_p as [id],
		nombre_p as [Nombre],
		costo_p as [Costo],
		precio_p as [Precio],
		existencia_p as [Stock],
		stock_seguridad as [Stock S],
		totalInventario as [Total],
		CASE
			WHEN estado_p = 1 THEN 'INSTOCK'
		END AS [Estado]
	FROM STOCK_P where estado_p = 1
END;