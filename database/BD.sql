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
	estado_ped TINYINT DEFAULT 1 NOT NULL,
);
go
CREATE TABLE DETALLE_PEDIDO
(
	id_dp INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	idPedido_dp INT FOREIGN KEY REFERENCES PEDIDO (id_ped) NOT NULL,
	idMP_dp SMALLINT FOREIGN KEY REFERENCES MATERIAL(id_mate) NOT NULL,
	descripcion_dp NVARCHAR(300) NULL,
	cantidad_dp TINYINT NOT NULL,
	costo_unitario_dp DECIMAL(5,2) NOT NULL,
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
CREATE OR ALTER PROC SP_VIEW_PRODUCTO
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
(@nombre varchar(50),@precio decimal(5,2),@costo decimal(5,2))
AS
BEGIN
	IF NOT EXISTS (SELECT nombre_prod FROM PRODUCTO p WHERE p.nombre_prod = @nombre)
		INSERT INTO PRODUCTO (nombre_prod,precio_prod,existencia_prod,costo_prod) VALUES (@nombre,@precio,0,@costo)
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
--|| PEDIDOS
CREATE OR ALTER PROC SP_VIEW_PEDIDO
(@tipo TINYINT)
AS
BEGIN
	SELECT
		p.id_ped as [Id],
		p.num_ped as [Pedido],
		p.fechaCompra_ped as [Fecha Compra],
		p.fechaEntrega_ped as [Fecha Entrega],
		p.idProv_ped as [Id Proveedor],
		pr.empresa_sup as [Empresa],
		pr.contacto_sup as [Vendedor],
		p.costoPedido_ped as [Costo.Pedido],
		CASE 
			WHEN p.estado_ped = 0 THEN 'INACTIVO'
			WHEN P.estado_ped = 1 THEN 'ESPERA'
			WHEN P.estado_ped = 2 THEN 'ACTIVO'
			ELSE 'ERROR'
		END AS [Estado]
	FROM PEDIDO p  INNER JOIN PROVEEDOR pr ON p.idProv_ped = pr.id_prov 
	WHERE (p.estado_ped = @tipo)
END;
go
CREATE OR ALTER PROC SP_CREATE_PEDIDO
(@PROV SMALLINT, @Costo DECIMAL(5,2),@FechaEntrega DATE)
AS
BEGIN
	IF EXISTS (SELECT id_prov FROM PROVEEDOR WHERE id_prov = @PROV AND estado_sup = 1)
		IF (@FechaEntrega >= GETDATE())
			INSERT INTO PEDIDO (idProv_ped, fechaEntrega_ped, costoPedido_ped, estado_ped) VALUES
				(@PROV,@FechaEntrega,@Costo,1)
		ELSE
			PRINT 'ERROR DATA'
	ELSE 
		PRINT 'ERROR CON ID'
END;
go
CREATE OR ALTER PROC SP_UPDATE_PEDIDO
(@Id INT, @idprov SMALLINT, @fechaE DATE, @costo DECIMAL(5,2))
AS
BEGIN
	IF (@Id = (SELECT id_ped FROM PEDIDO WHERE id_ped = @Id) AND @idprov = (SELECT id_prov FROM PROVEEDOR WHERE id_prov = @idprov AND estado_sup = 1))
		IF (@fechaE >= GETDATE())
			UPDATE PEDIDO SET idProv_ped =@idprov, fechaEntrega_ped=@fechaE, costoPedido_ped=@costo WHERE id_ped = @Id
		ELSE
			PRINT 'ERROR'
	ELSE
		PRINT 'ERROR IDENTIFICADOR'
END;
go
CREATE OR ALTER PROC SP_STATE_PEDIDO
(@Tipo TINYINT, @Id INT)
AS
BEGIN	
	DECLARE @STATE TINYINT = (SELECT estado_ped FROM PEDIDO WHERE id_ped = @Id)
	IF EXISTS (SELECT id_ped FROM PEDIDO WHERE id_ped = @Id)
		IF (@STATE = 1)
			IF (@Tipo = 0)
			BEGIN
				UPDATE PEDIDO SET estado_ped = @Tipo WHERE id_ped = @Id
			END
			ELSE IF (@Tipo = 2)
			BEGIN
				UPDATE PEDIDO SET estado_ped = @Tipo WHERE id_ped = @Id
			
				DECLARE @COUNT INT = (SELECT MIN(DETALLE_PEDIDO.id_dp) FROM DETALLE_PEDIDO WHERE DETALLE_PEDIDO.idPedido_dp = @Id)

				WHILE(@COUNT <= (SELECT MAX(DETALLE_PEDIDO.id_dp) FROM DETALLE_PEDIDO WHERE DETALLE_PEDIDO.idPedido_dp = @Id))
				BEGIN
					DECLARE @CANTIDAD SMALLINT = (SELECT DETALLE_PEDIDO.cantidad_dp FROM DETALLE_PEDIDO WHERE Id_dp = @COUNT)
					DECLARE @COSTO DECIMAL(5,2) = (SELECT DETALLE_PEDIDO.costo_unitario_dp FROM DETALLE_PEDIDO WHERE Id_dp = @COUNT)
					DECLARE @MP SMALLINT = (SELECT DETALLE_PEDIDO.idMP_dp FROM DETALLE_PEDIDO WHERE Id_dp = @COUNT)	

					UPDATE MATERIAL SET existencia_mate = (SELECT existencia_mate FROM MATERIAL WHERE id_mate =@MP) + @CANTIDAD, costo_mate = @COSTO WHERE id_mate = @MP

					SET @COUNT = @COUNT + 1 
				END
			END 
		ELSE 
			PRINT 'NO PUEDE REALIZAR OTRA ACCION'
	ELSE
		PRINT 'ERROR ID'
END;
go
--||DETALLE PEDIDO
CREATE OR ALTER PROC SP_VIEW_DETALLE_PEDIDO
(@IdPedido INT, @tipo TINYINT)
AS BEGIN
	IF EXISTS (SELECT id_ped FROM PEDIDO WHERE id_ped = @IdPedido)
		SELECT  
			id_dp AS [Id],
			idPedido_dp AS [Pedido],
			idMP_dp AS [MP],
			p.num_ped AS [Pedido],
			m.nombre_mate AS [Material],
			dp.descripcion_dp AS [Descripcion],
			dp.cantidad_dp AS [Cantidad],
			dp.costo_unitario_dp AS [Costo Unitario],
			(dp.costo_unitario_dp * dp.cantidad_dp) AS SUBTOTAL
		FROM DETALLE_PEDIDO dp INNER JOIN MATERIAL m ON m.id_mate = dp.idMP_dp
							   INNER JOIN PEDIDO P ON dp.idPedido_dp = p.id_ped
		WHERE (p.estado_ped = @tipo AND id_ped = @IdPedido)
	ELSE
		PRINT 'ERROR ID'
END;

select * from DETALLE_PEDIDO
go
CREATE OR ALTER PROC SP_CREATE_DETALLE_PEDIDO
(@Idp INT, @MP SMALLINT, @CANT TINYINT, @COSTO DECIMAL(5,2), @DESC NVARCHAR(300))
AS BEGIN
	IF (@Idp = (SELECT id_ped FROM PEDIDO WHERE id_ped = @Idp AND estado_ped != 0) AND @MP = (SELECT id_mate FROM MATERIAL WHERE id_mate = @MP AND estado_mate = 1))
		
		IF NOT EXISTS (SELECT idMP_dp FROM DETALLE_PEDIDO WHERE idMP_dp = @MP AND idPedido_dp = @Idp)
			INSERT INTO DETALLE_PEDIDO (idPedido_dp,idMP_dp,descripcion_dp,cantidad_dp,costo_unitario_dp)
				VALUES (@Idp,@mp,@DESC,@CANT,@COSTO)
		ELSE
			PRINT 'ERROR DUPLICADO ID DE MATERIA PRIMA'
	ELSE
		PRINT 'ERROR ID'
END;

select * from DETALLE_PEDIDO
go
CREATE OR ALTER PROC SP_UPDATE_DETALLE_PEDIDO
(@id INT, @MP SMALLINT, @CANT TINYINT, @COSTO DECIMAL(5,2), @DESC NVARCHAR(300))
AS BEGIN
	DECLARE @PEDIDO INT = (SELECT Id_dp FROM DETALLE_PEDIDO WHERE Id_dp =@id) 
	DECLARE @MATERIAL SMALLINT = (SELECT id_mate FROM MATERIAL WHERE id_mate = @MP AND estado_mate = 1)
	DECLARE @MPDUPLICADO SMALLINT = (SELECT idMP_dp FROM DETALLE_PEDIDO WHERE idMP_dp = @MP AND idPedido_dp = @PEDIDO AND id_dp != @id)
	DECLARE @ESTADOP TINYINT = (SELECT estado_ped FROM PEDIDO WHERE id_ped =@PEDIDO)

	IF (@ESTADOP = 1)
		IF EXISTS (SELECT id_dp FROM DETALLE_PEDIDO WHERE id_dp = @id)
			IF (@MP = @MATERIAL AND @MP != @MPDUPLICADO)
				UPDATE DETALLE_PEDIDO SET idMP_dp =@MP, cantidad_dp =@CANT, costo_unitario_dp=@COSTO, descripcion_dp=@DESC WHERE DETALLE_PEDIDO.id_dp = @id
			ELSE PRINT 'ERROR'
		ELSE PRINT 'ERROR ID'
	ELSE
		PRINT 'YA NO SE PUEDE MODIFICAR EL LISTADO DEL PEDIDO'
END;