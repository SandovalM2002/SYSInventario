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

CREATE OR ALTER PROC SP_VIEW_SEARCH_STOCK(@DATO VARCHAR(MAX), @T BIT) 
AS BEGIN
	IF (@T = 0) BEGIN
		SELECT
			id_s AS [Cod],
			nombre_s AS [Nombre],
			CASE 
				WHEN tipo_s = 0 THEN 'MATERIAL'
				WHEN tipo_s = 1 THEN 'PRODUCTO'
			END AS [Tipo],
			costo_s AS [Costo],
			existencia_s AS [Inventario],
			stock_seg_s AS [Stock Seguridad],
			totalMp AS [Total],
			CASE
				WHEN estado_mp = 1 THEN 'ACTIVO'
				WHEN estado_mp = 0 THEN 'INACTIVO'
			END AS [Estado]
		FROM STOCK WHERE estado_mp = 0 and 
					     nombre_s LIKE @DATO + '%' OR
						 estado_mp LIKE @DATO + '%'
	END
	ELSE IF (@T = 1) BEGIN
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
		FROM STOCK WHERE estado_mp = 1 and 
					     nombre_s LIKE @DATO + '%' OR
						 estado_mp LIKE @DATO + '%'
	END
END
GO
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
	IF EXISTS (SELECT id_nodo FROM NODO WHERE id_nodo =@Id) BEGIN
		UPDATE NODO SET cant_nodo =@q, t_nodo=@t WHERE id_nodo =@Id
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
	SELECT * FROM NODO N
END
go
