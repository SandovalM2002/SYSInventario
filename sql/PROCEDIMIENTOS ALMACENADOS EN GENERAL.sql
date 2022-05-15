USE InventarioSYS
go
CREATE OR ALTER PROC SP_ADD_STOCK (@N varchar(50), @t bit, @c decimal(5,2), @p decimal(5,2), @e int, @ss smallint)
AS BEGIN
	IF NOT EXISTS (SELECT nombre_s FROM STOCK WHERE nombre_s = @N) BEGIN
		INSERT INTO STOCK (nombre_s,tipo_s,costo_s,precio_p,existencia_s,stock_seg_s) 
						VALUES (@N,@T,@C,@P,@E,@ss)
	END
END;
go
CREATE OR ALTER PROC SP_UPDATE_STOCK (@Id int, @N varchar(50), @t bit, @c decimal(5,2), @p decimal(5,2), @e int, @ss smallint)
AS BEGIN
	IF EXISTS (SELECT id_s FROM STOCK WHERE id_s = @Id) BEGIN
		IF NOT EXISTS (SELECT nombre_s FROM STOCK WHERE nombre_s = @N AND id_s != @Id) BEGIN
			UPDATE STOCK SET nombre_s=@N, tipo_s=@t, costo_s=@c,precio_p=@p,existencia_s=@e,stock_seg_s=@ss WHERE id_s = @id
		END
	END
END;
go
CREATE OR ALTER PROC SP_DELETE_STOCK (@Id INT) 
AS BEGIN
	IF EXISTS (SELECT id_s FROM STOCK WHERE id_s = @Id) BEGIN
		UPDATE STOCK SET estado_mp = 0 WHERE id_s = @Id
	END
END;
go
CREATE OR ALTER PROC SP_VIEW_SEARCH_STOCK(@DATO VARCHAR(MAX)) 
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





go
--------------------------------------||METODOS DEL NODO
CREATE OR ALTER PROC SP_ADD_NODO (@p int, @h int, @q int, @t int)
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
go
CREATE OR ALTER PROC SP_UPDATE_NODO (@Id int, @q int, @t int) 
AS BEGIN
	IF EXISTS (SELECT id_nodo FROM NODO WHERE id_nodo = @Id) BEGIN
		DECLARE @H AS INT = (SELECT nodo_hijo FROM NODO WHERE id_nodo = @Id)
		DECLARE @DESC AS VARCHAR(70) = (SELECT nombre_s FROM STOCK WHERE id_s = @h) + '( '+convert(varchar,@q)+' )'

		UPDATE NODO SET cant_nodo =@q, t_nodo=@t, des_nodo =@DESC WHERE id_nodo =@Id
	END
END
go
CREATE OR ALTER PROC SP_DELETE_NODO (@Id int)
AS BEGIN
	IF EXISTS (SELECT id_nodo FROM NODO WHERE id_nodo =@Id) BEGIN
		DELETE NODO WHERE id_nodo =@Id
	END
END
go
CREATE OR ALTER PROC SP_VIEW_SEARCH_NODO 
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
go
CREATE OR ALTER PROC SP_ADD_PM
(@Nodo int, @Demanda int, @periodo int)
AS BEGIN
	IF EXISTS (SELECT id_nodo FROM NODO WHERE id_nodo = @Nodo)
		INSERT INTO PLAN_MAESTRO VALUES (@Nodo,@Demanda,@periodo)
END;
go
CREATE OR ALTER PROC SP_UPDATE_PM
(@ID int, @Nodo int, @Demanda int, @periodo int)
AS BEGIN
IF EXISTS (SELECT id FROM PLAN_MAESTRO WHERE id=@ID)
	IF EXISTS (SELECT id_nodo FROM NODO WHERE id_nodo = @Nodo)
		UPDATE PLAN_MAESTRO SET demanda =@Demanda, periodo =@periodo WHERE id =@ID
END;
go
CREATE OR ALTER PROC SP_DELETE_PM
(@id int)
AS BEGIN
	IF EXISTS (SELECT id FROM PLAN_MAESTRO WHERE id=@ID)
		DELETE PLAN_MAESTRO WHERE id =@id;
END;
go
CREATE OR ALTER PROC SP_VIEW_PM
AS BEGIN
	SELECT  
		PM.id as [Id],
		PM.Nodo as [Nodo],
		N.des_nodo as [Descripcion Nodo],
		PM.demanda as [Demanda],
		PM.periodo as [Periodo]
	FROM PLAN_MAESTRO PM INNER JOIN NODO N ON PM.Nodo = N.id_nodo
END;
go

create or alter proc SP_ADD_RP
(@nodo int, @periodo int, @cantidad int)
as begin
	if exists (select id_nodo from NODO where id_nodo= @nodo)
		insert into RECEPCION_PROGRAMADA values(@nodo,@periodo,@cantidad)
end;
go

create or alter proc SP_UPDATE_RP
(@id int,@nodo int, @periodo int, @cantidad int)
as begin
	if exists (select id from RECEPCION_PROGRAMADA where id= @id)
		if exists (select id_nodo from NODO where id_nodo= @nodo)
			update RECEPCION_PROGRAMADA set cantidad=@cantidad, periodo=@periodo where id=@id
end;
go

create or alter proc SP_DELETE_RP
(@id int)
as begin
	if exists (select id from RECEPCION_PROGRAMADA where id=id)
		delete from RECEPCION_PROGRAMADA where id=@id
end;
go

create or alter proc SP_VIEW_RP
as begin
	SELECT  
		RP.id as [Id],
		RP.Nodo as [Nodo],
		N.des_nodo as [Descripcion Nodo],
		RP.cantidad as [Cantidad],
		RP.periodo as [Periodo]
	FROM RECEPCION_PROGRAMADA RP INNER JOIN NODO N ON RP.Nodo = N.id_nodo
end;
go
