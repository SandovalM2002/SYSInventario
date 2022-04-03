CREATE DATABASE MAYER
go
USE MAYER
go
CREATE or alter PROC SP_ABC
AS
BEGIN
	DECLARE @A DECIMAL(18,2) = (SELECT 0.8*(SUM(totalInventario)) FROM STOCK_P)
	DECLARE @B DECIMAL(18,2) = (SELECT 0.15*(SUM(totalInventario)) FROM STOCK_P)
	DECLARE @C DECIMAL(18,2) = (SELECT 0.05*(SUM(totalInventario)) FROM STOCK_P)

	SELECT 
		id_p as [Id],
		nombre_p as [Nombre],
		totalInventario[Valor Inventario],
		CASE
			WHEN totalInventario <= @A AND totalInventario > @B THEN 'A'
			WHEN totalInventario <= @B AND totalInventario > @C THEN 'B'
			WHEN totalInventario <= @C THEN 'C'
		END AS [CATEGORIA ABC]
	FROM STOCK_P GROUP BY  id_p,nombre_p,totalInventario 
END;
go
