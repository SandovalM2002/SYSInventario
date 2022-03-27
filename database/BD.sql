CREATE DATABASE PanaderiaDb
go
USE PanaderiaDb
go
CREATE TABLE PRODUCTO 
(
	id_prod SMALLINT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	nombre_prod VARCHAR(50) NOT NULL,
	costo_prod DECIMAL(5,2) NOT NULL,
	existencia_prod SMALLINT NOT NULL,
	precio_prod DECIMAL (5,2) NULL,
	estado_prod BIT DEFAULT 1,
);
go
CREATE TABLE MATERIAL 
(
	id_mate SMALLINT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	nombre_mate VARCHAR(50) NOT NULL,
	costo_mate DECIMAL(5,2) NOT NULL,
	existencia_mate SMALLINT NOT NULL,
	estado_mate BIT DEFAULT 1, 
);
go
CREATE TABLE PROVEEDOR
(
	id_prov SMALLINT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	empresa_sup VARCHAR(30) NOT NULL,
	contacto_sup VARCHAR(50) NOT NULL, 
	estado_sup BIT DEFAULT 1,
);
go
CREATE TABLE BOOM
(	
	idProd_BOOM SMALLINT FOREIGN KEY REFERENCES PRODUCTO(id_prod) NOT NULL,
	idMaterial_BOOM SMALLINT FOREIGN KEY REFERENCES MATERIAL (id_mate) NOT NULL,
	cantidad_BOOM SMALLINT NOT NULL,
);
go
CREATE TABLE PEDIDO
(
	id_ped INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	num_ped AS ('No.'+ RIGHT('00000'+CONVERT(VARCHAR,id_ped),(5))),
	fechaCompra_ped AS GETDATE(),
	fechaEntrega_ped DATE NOT NULL,
	idProv_ped SMALLINT FOREIGN KEY REFERENCES PROVEEDOR(id_prov) NOT NULL,
	costoPedido_ped DECIMAL(5,2) NOT NULL,
	estado_op TINYINT NOT NULL,
);
go
CREATE TABLE DETALLE_PEDIDO
(
	idPedido_dp INT FOREIGN KEY REFERENCES PEDIDO (id_ped) NOT NULL,
	idMP_dp SMALLINT FOREIGN KEY REFERENCES MATERIAL(id_mate) NOT NULL,
	descripcion_dp NVARCHAR(300) NULL,
	cantidad_dp TINYINT NOT NULL,
	costo_unitario_dp DECIMAL(5,2) NOT NULL,

	CONSTRAINT PK_Idpedido PRIMARY KEY (idPedido_dp)
);
go
CREATE TABLE CLIENTE
(
	id_cli SMALLINT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	empresa_cli VARCHAR(30) NOT NULL,
	contacto_cli VARCHAR(50) NOT NULL, 
	estado_cli BIT DEFAULT 1,
);
go
CREATE TABLE VENTA
(
	id_ven INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	num_ven AS ('No.'+ RIGHT('00000'+CONVERT(VARCHAR,id_ven),(5))),
	fechaCompra_ven AS GETDATE(),
	idCliente_ven SMALLINT FOREIGN KEY REFERENCES CLIENTE(Id_cli) NOT NULL,
	Total_ven DECIMAL(8,2) NOT NULL,
	estado BIT NOT NULL,
);
go
CREATE TABLE DETALLE_VENTA
(
	idVenta_dv INT FOREIGN KEY REFERENCES VENTA (id_ven) NOT NULL,
	idP_dv SMALLINT FOREIGN KEY REFERENCES PRODUCTO(id_prod) NOT NULL,
	cantidad_dv TINYINT NOT NULL,
	precio_dv DECIMAL(5,2) NOT NULL,
	subTotal AS (cantidad_dv * precio_dv)
	CONSTRAINT PK_IdVenta PRIMARY KEY (idVenta_dv)
);
go
--|| STORE PROCEDURE PRODUCTO
CREATE OR ALTER PROC SP_VIEWPRODUCTO
(@TIPO BIT)
AS
BEGIN
	SELECT  
		id_prod AS [Id],
		nombre_prod AS [Nombre],
		costo_prod AS [Costo],
		existencia_prod AS [Stock],
		precio_prod AS [Precio],
		CASE
			WHEN estado_prod = 0 THEN 'INACTIVO'
			WHEN estado_prod = 1 THEN 'ACTIVO'
			ELSE 'NULL'
		END AS [Estado]
	FROM PRODUCTO WHERE estado_prod = @TIPO
END;
go
CREATE OR ALTER PROC SP_CREATE_PRODUCTO
(@nombre varchar(50), @costo decimal(5,2), @stock smallint, @precio decimal(5,2))
AS
BEGIN
	IF NOT EXISTS (SELECT nombre_prod FROM PRODUCTO p WHERE p.nombre_prod = @nombre)
		INSERT INTO PRODUCTO (nombre_prod,costo_prod,existencia_prod,precio_prod) VALUES (@nombre,@costo,@stock,@precio)
	ELSE 
		PRINT 'ERROR'
END;
go
CREATE OR ALTER PROC SP_UPDATE_PRODUCTO
(@id SMALLINT,@nombre varchar(50), @costo decimal(5,2), @precio decimal(5,2))
AS
BEGIN
	IF EXISTS (SELECT id_prod FROM PRODUCTO WHERE id_prod = @id)
		IF NOT EXISTS (SELECT nombre_prod FROM PRODUCTO p WHERE p.nombre_prod = @nombre AND id_prod != @id)
			UPDATE PRODUCTO SET nombre_prod = @nombre, costo_prod = @costo, precio_prod = @precio WHERE id_prod = @id
		ELSE 
			PRINT 'ERROR'
	ELSE
		PRINT 'NO EXISTE EL ID'
END;
go
CREATE OR ALTER PROC SP_STATE_PRODUCTO
(@id SMALLINT, @tipo bit)
AS
BEGIN 
	IF EXISTS (SELECT id_prod FROM PRODUCTO WHERE id_prod = @id)
		UPDATE PRODUCTO SET estado_prod = @tipo WHERE id_prod = @id
	ELSE
		PRINT 'ERROR ID'
END;
go
--|| STORE PROCEDURE PROVEEDOR
CREATE OR ALTER PROC SP_VIEW_PROVEEDOR
(@tipo BIT)
AS
BEGIN
	SELECT
		id_prov AS [Id],
		empresa_sup AS [Empresa],
		contacto_sup AS [Vendedor],
		CASE
			WHEN estado_sup = 0 THEN 'INACTIVO'
			WHEN estado_sup = 1 THEN 'ACTIVO'
			ELSE 'NULL'
		END AS [Estado]
	FROM PROVEEDOR WHERE estado_sup = @tipo
END;
go
CREATE OR ALTER PROC SP_CREATE_PROVEEDOR
(@empresa varchar(30), @contacto varchar(50))
AS 
BEGIN
	IF NOT EXISTS (SELECT empresa_sup FROM PROVEEDOR WHERE empresa_sup = @empresa)
		INSERT INTO PROVEEDOR (empresa_sup,contacto_sup) VALUES (@empresa,@contacto)
	ELSE	
		PRINT 'ERROR DE DUPLICADO'
END;
go
CREATE OR ALTER PROC SP_UPDATE_PROVEEDOR
(@id smallint, @empresa varchar(30), @contacto varchar(50))
AS
BEGIN
	IF EXISTS (SELECT id_prov FROM PROVEEDOR WHERE id_prov = @id)
		UPDATE PROVEEDOR SET empresa_sup = @empresa, contacto_sup = @contacto WHERE id_prov = @id
	ELSE 
		PRINT 'ERROR CON EL ID'
END;
go
CREATE OR ALTER PROC SP_STATE_PROVEEDOR
(@id smallint, @tipo bit)
AS
BEGIN
	IF EXISTS (SELECT id_prov FROM PROVEEDOR WHERE id_prov = @id)
		UPDATE PROVEEDOR SET estado_sup = @tipo WHERE id_prov = @id
	ELSE
		PRINT 'ERROR ID'
END;
go
CREATE OR ALTER PROC SP_VIEW_PEDIDO
(@tipo tinyint)
AS
BEGIN
	SELECT 
		p.id_ped as [Id],
		p.num_ped as [No],
		p.fechaCompra_ped as [Fecha Compra],
		p.fechaEntrega_ped as [Fecha Entrega],
		p.idProv_ped as [Id Proveedor],
		pr.empresa_sup as [Empresa],
		pr.contacto_sup as [Vendedor],
		p.costoPedido_ped as [Costo.Pedir],
		CASE 
			WHEN p.estado_op = 0 THEN 'INACTIVO'
			WHEN P.estado_op = 1 THEN 'ESPERA'
			WHEN P.estado_op = 2 THEN 'ACTIVO'
			ELSE 'ERROR'
		END AS [Estado]
	FROM PEDIDO p 
		INNER JOIN PROVEEDOR pr ON p.idProv_ped = pr.id_prov
		LEFT JOIN DETALLE_PEDIDO dp ON dp.idPedido_dp = p.id_ped
END;