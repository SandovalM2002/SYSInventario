CREATE DATABASE InventarioSYS
go
USE InventarioSYS
go
CREATE OR ALTER PROC SP_ABC
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
go
