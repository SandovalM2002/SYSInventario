CREATE DATABASE InventarioSYS
go
USE InventarioSYS
go
--||TABLAS DE LA BD
CREATE TABLE STOCK
(
	id_s int primary key identity(1,1) not null,
	nombre_s varchar(50) not null,
	tipo_s bit default 1 not null,
	costo_s decimal(5,2) not null,
	[precio_p] [decimal](5,2) null,
	existencia_s int default 0 not null,
	stock_seg_s smallint default 0 null,
	totalMp AS (costo_s * existencia_s),
	estado_mp bit default 1
);
go
CREATE TABLE [dbo].[NODO]
(
	[id_nodo] [int] IDENTITY(1,1) PRIMARY KEY NOT NULL,
	[nodo_padre] [int] NOT NULL,
	[nodo_hijo] [int]  NOT NULL,
	[des_nodo] [varchar](70) NOT NULL,
	[cant_nodo] [int] NOT NULL,
	[t_nodo] [int] NULL,
)
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
CREATE TABLE MRP
(
	id_MRP int IDENTITY(1,1) primary key not null,
	id_nodo int foreign key references NODO(id_nodo) not null,
);
go
CREATE TABLE DETALLE_MRP
(
	--CABECERA
	id_detalle int identity(1,1) primary key not null,
	id_MRP int foreign key references MRP(id_MRP) not null,
	--CONCEPTOS MAS MONTO
	NB_MRP int default 0 not null,
	RP_MRP int default 0 not null,	
	D_MRP int default 0 not null,
	NN_MRP int default 0 not null,
	RO_MRP int default 0 not null,
	LO_MRP int default 0 not null,
	--PERIODO
	periodo int  not null
);
go
--|| ==========================================================================|| STORAGE PROCEDURES MRP METODO LOTE X LOTE
CREATE OR ALTER PROC SP_INSERT_MRP (@Nodo INT)
AS BEGIN
	IF NOT EXISTS (SELECT id_nodo FROM MRP WHERE id_nodo = @Nodo)
		INSERT INTO MRP(id_nodo) VALUES (@Nodo)
END;
go
CREATE OR ALTER PROC SP_EXPLOSION_MRP (@nodo INT)
AS BEGIN
	DECLARE @PADRE INT = (SELECT nodo_padre FROM NODO WHERE id_nodo = @nodo)
	DECLARE @MRP INT = (SELECT id_MRP FROM MRP WHERE id_nodo = @nodo)
	DECLARE @t_nodo AS INT = (SELECT t_nodo FROM NODO WHERE id_nodo = @nodo)

	DECLARE @DEMANDA INT
	DECLARE @RP INT
	DECLARE @D INT
	DECLARE @NN INT
	DECLARE @COUNT INT = 1

	IF NOT EXISTS (SELECT id_MRP FROM DETALLE_MRP WHERE id_MRP = @MRP) BEGIN
		IF (@PADRE = 0) BEGIN
			WHILE(@COUNT <= (SELECT COUNT(*) FROM PLAN_MAESTRO where Nodo = @nodo))	 BEGIN	
				
				SET @DEMANDA = (SELECT demanda FROM PLAN_MAESTRO WHERE NODO = @nodo AND periodo = @COUNT)
				SET @RP = dbo.FN_RECEPCIONES(@nodo,@COUNT)
				SET @D = dbo.FN_DISPONIBLES(@DEMANDA,@nodo,@RP)			
				SET @NN = dbo.FN_NETAS(@DEMANDA,@nodo,@RP)
			
				EXEC SP_UPDATE_STOCK_MRP @nodo,@D
				
				IF(@NN > 0 AND (@COUNT - @t_nodo) > 0) BEGIN
					UPDATE DETALLE_MRP SET LO_MRP = @NN  WHERE id_detalle = (SELECT id_detalle FROM DETALLE_MRP WHERE periodo = @COUNT - (@t_nodo) AND id_MRP = @MRP)
				END

				INSERT INTO DETALLE_MRP (id_MRP,NB_MRP,RP_MRP,D_MRP,NN_MRP,RO_MRP,LO_MRP,periodo) VALUES(@MRP,@DEMANDA,@RP,@D,@NN,@NN,0,@COUNT)
				SET @COUNT = @COUNT + 1
			END
		END
		ELSE IF (@PADRE > 0) BEGIN
			
			DECLARE @ID_NODO INT = (SELECT id_nodo FROM NODO WHERE nodo_hijo = @PADRE)
			DECLARE @ID_NODO_MRP INT  = (SELECT id_MRP FROM MRP WHERE id_nodo=@ID_NODO)

			WHILE (@COUNT <= (SELECT COUNT(*) FROM DETALLE_MRP WHERE id_MRP = @ID_NODO_MRP)) BEGIN --ESTA BIEN HASTA AQUI
				
				SET @DEMANDA = (SELECT LO_MRP FROM DETALLE_MRP WHERE periodo = @COUNT) * (SELECT cant_nodo FROM NODO where id_nodo = @nodo)
				SET @RP = dbo.FN_RECEPCIONES(@nodo,@COUNT)
				SET @D = dbo.FN_DISPONIBLES(@DEMANDA,@nodo,@RP)			
				SET @NN = dbo.FN_NETAS(@DEMANDA,@nodo,@RP)

				EXEC SP_UPDATE_STOCK_MRP @nodo,@D
				
				IF(@NN > 0 AND (@COUNT - @t_nodo) > 0) BEGIN
					UPDATE DETALLE_MRP SET LO_MRP = @NN  WHERE id_detalle = (SELECT id_detalle FROM DETALLE_MRP WHERE periodo = @COUNT - (@t_nodo) AND id_MRP = @MRP)
				END

				INSERT INTO DETALLE_MRP (id_MRP,NB_MRP,RP_MRP,D_MRP,NN_MRP,RO_MRP,LO_MRP,periodo) VALUES(@MRP,@DEMANDA,@RP,@D,@NN,@NN,0,@COUNT)
				SET @COUNT = @COUNT + 1	
			END
		END
	END
END;
go
CREATE OR ALTER PROC SP_UPDATE_STOCK_MRP
(@NODO INT,@CANT INT)
AS BEGIN
	DECLARE @PROD_MATE INT = (SELECT id_s FROM STOCK WHERE id_s = (SELECT nodo_hijo FROM NODO WHERE id_nodo = @NODO))
	IF(@CANT >= 0)
		UPDATE STOCK SET existencia_s = @CANT WHERE id_s = @PROD_MATE
END;
go
--|| ==========================================================================|| FUNCIONES PARA MRP METODO
go
CREATE OR ALTER FUNCTION FN_RECEPCIONES
(@NODO INT, @COUNT INT)
RETURNS INT
AS BEGIN
	DECLARE @RESULT INT
	IF EXISTS (SELECT Nodo FROM RECEPCION_PROGRAMADA WHERE Nodo = @NODO AND periodo = @COUNT) 
		SET @RESULT = (SELECT cantidad FROM RECEPCION_PROGRAMADA WHERE Nodo = @nodo AND periodo=@COUNT)
	ELSE 
		SET @RESULT = 0
	RETURN @RESULT
END;
go
CREATE OR ALTER FUNCTION FN_DISPONIBLES (@D INT, @NODO INT, @RP INT)
RETURNS INT
AS BEGIN
	DECLARE @RESULT INT
	
	DECLARE @ID_STOCK INT = (SELECT id_s FROM STOCK WHERE id_s = (SELECT nodo_hijo FROM NODO WHERE id_nodo = @NODO))
	DECLARE @SS INT = (SELECT stock_seg_s FROM STOCK WHERE id_s = @ID_STOCK)
	DECLARE @STOCK INT = (SELECT existencia_s FROM STOCK WHERE id_s = @ID_STOCK)
	
	IF (@D = 0) BEGIN
		SET @RESULT = @STOCK
	END
	ELSE BEGIN
		IF ((@STOCK + @RP - @SS) >= @D) BEGIN
			SET @RESULT = @STOCK - @D
		END	
		ELSE IF (@D > (@STOCK + @RP - @SS)) BEGIN
			SET @RESULT = @SS
		END	
	END
	RETURN @RESULT
END;
go
CREATE OR ALTER FUNCTION FN_NETAS (@D INT, @NODO INT,@RP INT)
RETURNS INT
AS BEGIN
	
	DECLARE @RESULT INT 
	DECLARE @ID_STOCK INT = (SELECT id_s FROM STOCK WHERE id_s = (SELECT nodo_hijo FROM NODO WHERE id_nodo = @NODO))
	DECLARE @SS INT = (SELECT stock_seg_s FROM STOCK WHERE id_s = @ID_STOCK)
	DECLARE @STOCK INT = (SELECT existencia_s FROM STOCK WHERE id_s = @ID_STOCK)

	IF (@D > (@STOCK-@SS+@RP)) BEGIN
		IF (@STOCK = 0) BEGIN
			SET @RESULT = @D
		END
		ELSE BEGIN
			SET @RESULT = @D - ((@STOCK-@SS)+@RP)
		END
	END
	ELSE BEGIN
		SET @RESULT = 0
	END
	RETURN @RESULT
END;
go
select * from NODO
select * from MRP
select * from DETALLE_MRP WHERE id_MRP = 2
select * from STOCK

EXEC SP_EXPLOSION_MRP 2
go
drop table DETALLE_MRP
