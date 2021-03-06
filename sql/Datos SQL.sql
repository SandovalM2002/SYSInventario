USE [master]
GO
/****** Object:  Database [InventarioSYS]    Script Date: 5/17/2022 8:10:36 AM ******/
CREATE DATABASE [InventarioSYS]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'InventarioSYS', FILENAME = N'D:\programas\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\InventarioSYS.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'InventarioSYS_log', FILENAME = N'D:\programas\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\InventarioSYS_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [InventarioSYS] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [InventarioSYS].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [InventarioSYS] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [InventarioSYS] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [InventarioSYS] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [InventarioSYS] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [InventarioSYS] SET ARITHABORT OFF 
GO
ALTER DATABASE [InventarioSYS] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [InventarioSYS] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [InventarioSYS] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [InventarioSYS] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [InventarioSYS] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [InventarioSYS] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [InventarioSYS] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [InventarioSYS] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [InventarioSYS] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [InventarioSYS] SET  ENABLE_BROKER 
GO
ALTER DATABASE [InventarioSYS] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [InventarioSYS] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [InventarioSYS] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [InventarioSYS] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [InventarioSYS] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [InventarioSYS] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [InventarioSYS] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [InventarioSYS] SET RECOVERY FULL 
GO
ALTER DATABASE [InventarioSYS] SET  MULTI_USER 
GO
ALTER DATABASE [InventarioSYS] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [InventarioSYS] SET DB_CHAINING OFF 
GO
ALTER DATABASE [InventarioSYS] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [InventarioSYS] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [InventarioSYS] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [InventarioSYS] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'InventarioSYS', N'ON'
GO
ALTER DATABASE [InventarioSYS] SET QUERY_STORE = OFF
GO
USE [InventarioSYS]
GO
/****** Object:  UserDefinedFunction [dbo].[FN_DISPONIBLES]    Script Date: 5/17/2022 8:10:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   FUNCTION [dbo].[FN_DISPONIBLES] (@D INT, @NODO INT, @RP INT)
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
GO
/****** Object:  UserDefinedFunction [dbo].[FN_NETAS]    Script Date: 5/17/2022 8:10:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   FUNCTION [dbo].[FN_NETAS] (@D INT, @NODO INT,@RP INT)
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
GO
/****** Object:  UserDefinedFunction [dbo].[FN_RECEPCIONES]    Script Date: 5/17/2022 8:10:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   FUNCTION [dbo].[FN_RECEPCIONES]
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
GO
/****** Object:  Table [dbo].[DETALLE_MRP]    Script Date: 5/17/2022 8:10:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DETALLE_MRP](
	[id_detalle] [int] IDENTITY(1,1) NOT NULL,
	[id_MRP] [int] NOT NULL,
	[NB_MRP] [int] NOT NULL,
	[RP_MRP] [int] NOT NULL,
	[D_MRP] [int] NOT NULL,
	[NN_MRP] [int] NOT NULL,
	[RO_MRP] [int] NOT NULL,
	[LO_MRP] [int] NOT NULL,
	[periodo] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_detalle] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MRP]    Script Date: 5/17/2022 8:10:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MRP](
	[id_MRP] [int] IDENTITY(1,1) NOT NULL,
	[id_nodo] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_MRP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NODO]    Script Date: 5/17/2022 8:10:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NODO](
	[id_nodo] [int] IDENTITY(1,1) NOT NULL,
	[nodo_padre] [int] NOT NULL,
	[nodo_hijo] [int] NOT NULL,
	[des_nodo] [varchar](70) NOT NULL,
	[cant_nodo] [int] NOT NULL,
	[t_nodo] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_nodo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PLAN_MAESTRO]    Script Date: 5/17/2022 8:10:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PLAN_MAESTRO](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Nodo] [int] NOT NULL,
	[demanda] [int] NOT NULL,
	[periodo] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RECEPCION_PROGRAMADA]    Script Date: 5/17/2022 8:10:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RECEPCION_PROGRAMADA](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Nodo] [int] NOT NULL,
	[periodo] [int] NOT NULL,
	[cantidad] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[STOCK]    Script Date: 5/17/2022 8:10:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[STOCK](
	[id_s] [int] IDENTITY(1,1) NOT NULL,
	[nombre_s] [varchar](50) NOT NULL,
	[tipo_s] [bit] NOT NULL,
	[costo_s] [decimal](5, 2) NOT NULL,
	[precio_p] [decimal](5, 2) NULL,
	[existencia_s] [int] NOT NULL,
	[stock_seg_s] [smallint] NULL,
	[totalMp]  AS ([costo_s]*[existencia_s]),
	[estado_mp] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_s] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[MRP] ON 

INSERT [dbo].[MRP] ([id_MRP], [id_nodo]) VALUES (1, 1)
SET IDENTITY_INSERT [dbo].[MRP] OFF
GO
SET IDENTITY_INSERT [dbo].[NODO] ON 

INSERT [dbo].[NODO] ([id_nodo], [nodo_padre], [nodo_hijo], [des_nodo], [cant_nodo], [t_nodo]) VALUES (1, 0, 1, N'Producto (x)', 1, 2)
INSERT [dbo].[NODO] ([id_nodo], [nodo_padre], [nodo_hijo], [des_nodo], [cant_nodo], [t_nodo]) VALUES (2, 1, 2, N'Material (A)', 2, 3)
INSERT [dbo].[NODO] ([id_nodo], [nodo_padre], [nodo_hijo], [des_nodo], [cant_nodo], [t_nodo]) VALUES (3, 2, 4, N'Material (C)', 3, 2)
INSERT [dbo].[NODO] ([id_nodo], [nodo_padre], [nodo_hijo], [des_nodo], [cant_nodo], [t_nodo]) VALUES (4, 1, 3, N'Material (B)', 1, 1)
INSERT [dbo].[NODO] ([id_nodo], [nodo_padre], [nodo_hijo], [des_nodo], [cant_nodo], [t_nodo]) VALUES (5, 3, 4, N'Material (C)', 2, 2)
INSERT [dbo].[NODO] ([id_nodo], [nodo_padre], [nodo_hijo], [des_nodo], [cant_nodo], [t_nodo]) VALUES (6, 3, 5, N'Material (D)', 4, 2)
SET IDENTITY_INSERT [dbo].[NODO] OFF
GO
SET IDENTITY_INSERT [dbo].[PLAN_MAESTRO] ON 

INSERT [dbo].[PLAN_MAESTRO] ([id], [Nodo], [demanda], [periodo]) VALUES (1, 1, 100, 10)
SET IDENTITY_INSERT [dbo].[PLAN_MAESTRO] OFF
GO
SET IDENTITY_INSERT [dbo].[STOCK] ON 

INSERT [dbo].[STOCK] ([id_s], [nombre_s], [tipo_s], [costo_s], [precio_p], [existencia_s], [stock_seg_s], [estado_mp]) VALUES (1, N'Producto X', 1, CAST(100.00 AS Decimal(5, 2)), CAST(800.00 AS Decimal(5, 2)), 40, 0, 1)
INSERT [dbo].[STOCK] ([id_s], [nombre_s], [tipo_s], [costo_s], [precio_p], [existencia_s], [stock_seg_s], [estado_mp]) VALUES (2, N'Material A', 0, CAST(20.00 AS Decimal(5, 2)), CAST(0.00 AS Decimal(5, 2)), 60, 0, 1)
INSERT [dbo].[STOCK] ([id_s], [nombre_s], [tipo_s], [costo_s], [precio_p], [existencia_s], [stock_seg_s], [estado_mp]) VALUES (3, N'Material B', 0, CAST(8.00 AS Decimal(5, 2)), CAST(0.00 AS Decimal(5, 2)), 20, 0, 1)
INSERT [dbo].[STOCK] ([id_s], [nombre_s], [tipo_s], [costo_s], [precio_p], [existencia_s], [stock_seg_s], [estado_mp]) VALUES (4, N'Material C', 0, CAST(42.00 AS Decimal(5, 2)), CAST(0.00 AS Decimal(5, 2)), 10, 0, 1)
INSERT [dbo].[STOCK] ([id_s], [nombre_s], [tipo_s], [costo_s], [precio_p], [existencia_s], [stock_seg_s], [estado_mp]) VALUES (5, N'Material D', 0, CAST(2.00 AS Decimal(5, 2)), CAST(0.00 AS Decimal(5, 2)), 20, 0, 1)
SET IDENTITY_INSERT [dbo].[STOCK] OFF
GO
ALTER TABLE [dbo].[DETALLE_MRP] ADD  DEFAULT ((0)) FOR [NB_MRP]
GO
ALTER TABLE [dbo].[DETALLE_MRP] ADD  DEFAULT ((0)) FOR [RP_MRP]
GO
ALTER TABLE [dbo].[DETALLE_MRP] ADD  DEFAULT ((0)) FOR [D_MRP]
GO
ALTER TABLE [dbo].[DETALLE_MRP] ADD  DEFAULT ((0)) FOR [NN_MRP]
GO
ALTER TABLE [dbo].[DETALLE_MRP] ADD  DEFAULT ((0)) FOR [RO_MRP]
GO
ALTER TABLE [dbo].[DETALLE_MRP] ADD  DEFAULT ((0)) FOR [LO_MRP]
GO
ALTER TABLE [dbo].[STOCK] ADD  DEFAULT ((1)) FOR [tipo_s]
GO
ALTER TABLE [dbo].[STOCK] ADD  DEFAULT ((0)) FOR [existencia_s]
GO
ALTER TABLE [dbo].[STOCK] ADD  DEFAULT ((0)) FOR [stock_seg_s]
GO
ALTER TABLE [dbo].[STOCK] ADD  DEFAULT ((1)) FOR [estado_mp]
GO
ALTER TABLE [dbo].[DETALLE_MRP]  WITH CHECK ADD FOREIGN KEY([id_MRP])
REFERENCES [dbo].[MRP] ([id_MRP])
GO
ALTER TABLE [dbo].[DETALLE_MRP]  WITH CHECK ADD FOREIGN KEY([id_MRP])
REFERENCES [dbo].[MRP] ([id_MRP])
GO
ALTER TABLE [dbo].[MRP]  WITH CHECK ADD FOREIGN KEY([id_nodo])
REFERENCES [dbo].[NODO] ([id_nodo])
GO
ALTER TABLE [dbo].[MRP]  WITH CHECK ADD FOREIGN KEY([id_nodo])
REFERENCES [dbo].[NODO] ([id_nodo])
GO
ALTER TABLE [dbo].[PLAN_MAESTRO]  WITH CHECK ADD FOREIGN KEY([Nodo])
REFERENCES [dbo].[NODO] ([id_nodo])
GO
ALTER TABLE [dbo].[PLAN_MAESTRO]  WITH CHECK ADD FOREIGN KEY([Nodo])
REFERENCES [dbo].[NODO] ([id_nodo])
GO
ALTER TABLE [dbo].[RECEPCION_PROGRAMADA]  WITH CHECK ADD FOREIGN KEY([Nodo])
REFERENCES [dbo].[NODO] ([id_nodo])
GO
ALTER TABLE [dbo].[RECEPCION_PROGRAMADA]  WITH CHECK ADD FOREIGN KEY([Nodo])
REFERENCES [dbo].[NODO] ([id_nodo])
GO
/****** Object:  StoredProcedure [dbo].[SP_ABC]    Script Date: 5/17/2022 8:10:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROC [dbo].[SP_ABC]
AS
BEGIN
	DECLARE @A DECIMAL(18,2) = (SELECT 0.8*(SUM(totalMp)) FROM STOCK)
	DECLARE @B DECIMAL(18,2) = (SELECT 0.15*(SUM(totalMp)) FROM STOCK)
	DECLARE @C DECIMAL(18,2) = (SELECT 0.05*(SUM(totalMp)) FROM STOCK)

	SELECT 
		id_s as [Cod],
		nombre_s as [Nombre],
		totalMp as [Total Inventario],
		CASE
			WHEN totalMp >= @A AND totalMp > @B THEN 'A'
			WHEN totalMp <= @B AND totalMp > @C THEN 'B'
			WHEN totalMp <= @C THEN 'C'
		END AS [CATEGORIA ABC]
	FROM STOCK GROUP BY  id_s,nombre_s,totalMp
END;
GO
/****** Object:  StoredProcedure [dbo].[SP_ADD_NODO]    Script Date: 5/17/2022 8:10:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--------------------------------------||METODOS DEL NODO
CREATE   PROC [dbo].[SP_ADD_NODO] (@p int, @h int, @q int, @t int)
AS BEGIN
	IF NOT EXISTS (SELECT nodo_hijo FROM NODO WHERE nodo_hijo =@h) BEGIN
		DECLARE @DESC AS VARCHAR(70) = (SELECT nombre_s FROM STOCK WHERE id_s = @h) + '( '+convert(varchar,@q)+' )'
		IF(@P = 0) 
			INSERT INTO NODO (nodo_padre,nodo_hijo,des_nodo,cant_nodo,t_nodo)
						VALUES(@p,@h,@DESC,@q,@t)
		ELSE 
			INSERT INTO NODO (nodo_padre,nodo_hijo,des_nodo,cant_nodo,t_nodo)
						VALUES(@p,@h,@DESC,@q,@t)
	END
END;
GO
/****** Object:  StoredProcedure [dbo].[SP_ADD_PM]    Script Date: 5/17/2022 8:10:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROC [dbo].[SP_ADD_PM]
(@Nodo int, @Demanda int, @periodo int)
AS BEGIN
	IF EXISTS (SELECT id_nodo FROM NODO WHERE id_nodo = @Nodo)
		INSERT INTO PLAN_MAESTRO VALUES (@Nodo,@Demanda,@periodo)
END;
GO
/****** Object:  StoredProcedure [dbo].[SP_ADD_STOCK]    Script Date: 5/17/2022 8:10:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROC [dbo].[SP_ADD_STOCK] (@N varchar(50), @t bit, @c decimal(5,2), @p decimal(5,2), @e int, @ss smallint)
AS BEGIN
	IF NOT EXISTS (SELECT nombre_s FROM STOCK WHERE nombre_s = @N) BEGIN
		INSERT INTO STOCK (nombre_s,tipo_s,costo_s,precio_p,existencia_s,stock_seg_s) 
						VALUES (@N,@T,@C,@P,@E,@ss)
	END
END;
GO
/****** Object:  StoredProcedure [dbo].[SP_DELETE_NODO]    Script Date: 5/17/2022 8:10:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROC [dbo].[SP_DELETE_NODO] (@Id int)
AS BEGIN
	IF EXISTS (SELECT id_nodo FROM NODO WHERE id_nodo =@Id) BEGIN
		DELETE NODO WHERE id_nodo =@Id
	END
END
GO
/****** Object:  StoredProcedure [dbo].[SP_DELETE_PM]    Script Date: 5/17/2022 8:10:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROC [dbo].[SP_DELETE_PM]
(@id int)
AS BEGIN
	IF EXISTS (SELECT id FROM PLAN_MAESTRO WHERE id=@ID)
		DELETE PLAN_MAESTRO WHERE id =@id;
END;
GO
/****** Object:  StoredProcedure [dbo].[SP_DELETE_STOCK]    Script Date: 5/17/2022 8:10:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROC [dbo].[SP_DELETE_STOCK] (@Id INT) 
AS BEGIN
	IF EXISTS (SELECT id_s FROM STOCK WHERE id_s = @Id) BEGIN
		UPDATE STOCK SET estado_mp = 0 WHERE id_s = @Id
	END
END;
GO
/****** Object:  StoredProcedure [dbo].[SP_EXPLOSION_MRP]    Script Date: 5/17/2022 8:10:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROC [dbo].[SP_EXPLOSION_MRP] (@nodo INT)
AS BEGIN
	DECLARE @PADRE INT = (SELECT nodo_padre FROM NODO WHERE id_nodo = @nodo)
	DECLARE @t_nodo AS INT = (SELECT t_nodo FROM NODO WHERE id_nodo = @nodo)

	DECLARE @DEMANDA INT
	DECLARE @RP INT
	DECLARE @D INT
	DECLARE @NN INT
	
	EXEC SP_INSERT_MRP @nodo
	DECLARE @MRP INT = (SELECT id_MRP FROM MRP WHERE id_nodo = @nodo)

	DECLARE @COUNT INT = 1

	IF NOT EXISTS (SELECT id_MRP FROM DETALLE_MRP WHERE id_MRP = @MRP) BEGIN
		IF (@PADRE = 0) BEGIN
			WHILE(@COUNT <= (SELECT COUNT(*) FROM PLAN_MAESTRO where Nodo = @nodo))	BEGIN	
				
				IF NOT EXISTS (SELECT demanda FROM PLAN_MAESTRO WHERE NODO = @nodo AND periodo = @COUNT)
					SET @DEMANDA = 0
				ELSE
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
				
				IF NOT EXISTS ((SELECT LO_MRP FROM DETALLE_MRP WHERE periodo = @COUNT AND id_MRP = @ID_NODO_MRP)) BEGIN
					SET @DEMANDA = 0
				END
				ELSE BEGIN
					SET @DEMANDA = (SELECT LO_MRP FROM DETALLE_MRP WHERE periodo = @COUNT AND id_MRP = @ID_NODO_MRP) * (SELECT cant_nodo FROM NODO where id_nodo = @nodo)
				END
				
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
GO
/****** Object:  StoredProcedure [dbo].[SP_INSERT_MRP]    Script Date: 5/17/2022 8:10:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROC [dbo].[SP_INSERT_MRP] (@Nodo INT)
AS BEGIN
	IF NOT EXISTS (SELECT id_nodo FROM MRP WHERE id_nodo = @Nodo)
		INSERT INTO MRP(id_nodo) VALUES (@Nodo)
END;
GO
/****** Object:  StoredProcedure [dbo].[SP_UPDATE_NODO]    Script Date: 5/17/2022 8:10:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROC [dbo].[SP_UPDATE_NODO] (@Id int, @q int, @t int) 
AS BEGIN
	IF EXISTS (SELECT id_nodo FROM NODO WHERE id_nodo = @Id) BEGIN
		DECLARE @H AS INT = (SELECT nodo_hijo FROM NODO WHERE id_nodo = @Id)
		DECLARE @DESC AS VARCHAR(70) = (SELECT nombre_s FROM STOCK WHERE id_s = @h) + '( '+convert(varchar,@q)+' )'

		UPDATE NODO SET cant_nodo =@q, t_nodo=@t, des_nodo =@DESC WHERE id_nodo =@Id
	END
END
GO
/****** Object:  StoredProcedure [dbo].[SP_UPDATE_PM]    Script Date: 5/17/2022 8:10:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROC [dbo].[SP_UPDATE_PM]
(@ID int, @Nodo int, @Demanda int, @periodo int)
AS BEGIN
IF EXISTS (SELECT id FROM PLAN_MAESTRO WHERE id=@ID)
	IF EXISTS (SELECT id_nodo FROM NODO WHERE id_nodo = @Nodo)
		UPDATE PLAN_MAESTRO SET demanda =@Demanda, periodo =@periodo WHERE id =@ID
END;
GO
/****** Object:  StoredProcedure [dbo].[SP_UPDATE_STOCK]    Script Date: 5/17/2022 8:10:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROC [dbo].[SP_UPDATE_STOCK] (@Id int, @N varchar(50), @t bit, @c decimal(5,2), @p decimal(5,2), @e int, @ss smallint)
AS BEGIN
	IF EXISTS (SELECT id_s FROM STOCK WHERE id_s = @Id) BEGIN
		IF NOT EXISTS (SELECT nombre_s FROM STOCK WHERE nombre_s = @N AND id_s != @Id) BEGIN
			UPDATE STOCK SET nombre_s=@N, tipo_s=@t, costo_s=@c,precio_p=@p,existencia_s=@e,stock_seg_s=@ss WHERE id_s = @id
		END
	END
END;
GO
/****** Object:  StoredProcedure [dbo].[SP_UPDATE_STOCK_MRP]    Script Date: 5/17/2022 8:10:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROC [dbo].[SP_UPDATE_STOCK_MRP]
(@NODO INT,@CANT INT)
AS BEGIN
	DECLARE @PROD_MATE INT = (SELECT id_s FROM STOCK WHERE id_s = (SELECT nodo_hijo FROM NODO WHERE id_nodo = @NODO))
	IF(@CANT >= 0)
		UPDATE STOCK SET existencia_s = @CANT WHERE id_s = @PROD_MATE
END;
GO
/****** Object:  StoredProcedure [dbo].[SP_VIEW_MRP]    Script Date: 5/17/2022 8:10:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROC [dbo].[SP_VIEW_MRP] (@nodo int)
AS BEGIN
	SELECT 
		periodo as [Periodo],
		NB_MRP as [Necesidades Brutas],
		RP_MRP as [Recepciones Programadas],
		D_MRP as [Disponible],
		RO_MRP as [Recepción de Orden],
		LO_MRP as [Lanzamiento de Orden]
	FROM DETALLE_MRP WHERE id_MRP = (SELECT id_MRP FROM MRP WHERE id_nodo = @nodo)
END;
GO
/****** Object:  StoredProcedure [dbo].[SP_VIEW_PM]    Script Date: 5/17/2022 8:10:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROC [dbo].[SP_VIEW_PM]
AS BEGIN
	SELECT  
		PM.id as [Id],
		PM.Nodo as [Nodo],
		N.des_nodo as [Descripcion Nodo],
		PM.demanda as [Demanda],
		PM.periodo as [Periodo]
	FROM PLAN_MAESTRO PM INNER JOIN NODO N ON PM.Nodo = N.id_nodo
END;
GO
/****** Object:  StoredProcedure [dbo].[SP_VIEW_SEARCH_NODO]    Script Date: 5/17/2022 8:10:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROC [dbo].[SP_VIEW_SEARCH_NODO] 
AS BEGIN
	SELECT  
		id_nodo as [Cod],
		nodo_padre as [Padre],
		nodo_hijo as [Hijo],
		des_nodo as [Descripción],
		cant_nodo as [Cantidad],
		t_nodo as [Periodos]
	FROM NODO N
END
GO
/****** Object:  StoredProcedure [dbo].[SP_VIEW_SEARCH_STOCK]    Script Date: 5/17/2022 8:10:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROC [dbo].[SP_VIEW_SEARCH_STOCK](@DATO VARCHAR(MAX)) 
AS BEGIN
	SELECT
		id_s AS [Cod],
		nombre_s AS [Nombre],
		CASE 
			WHEN tipo_s = 0 THEN 'MATERIAL'
			WHEN tipo_s = 1 THEN 'PRODUCTO'
		END AS [Tipo],
		costo_s AS [Costo],
		precio_p AS[Precio],
		existencia_s AS [Inventario],
		stock_seg_s AS [Stock Seguridad],
		totalMp AS [Total],
		CASE
			WHEN estado_mp = 1 THEN 'ACTIVO'
			WHEN estado_mp = 0 THEN 'INACTIVO'
		END AS [Estado]
	FROM STOCK WHERE estado_mp = 1 and  nombre_s LIKE @DATO + '%'
END





GO
USE [master]
GO
ALTER DATABASE [InventarioSYS] SET  READ_WRITE 
GO
