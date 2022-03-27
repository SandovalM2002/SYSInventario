SELECT DISTINCT id_ped, 
       COUNT(id_ped) as [No de Materia Prima],
       SUM((dp.cantidad_dp)* dp.costo_unitario_dp) as totalPrice,
	   dp.idMP_dp as [Id Materia],
	   m.nombre_mate as [MP]
FROM PEDIDO p 
	INNER JOIN PROVEEDOR pr ON p.idProv_ped = pr.id_prov
	INNER JOIN DETALLE_PEDIDO dp ON dp.idPedido_dp = p.id_ped
	INNER JOIN MATERIAL m ON dp.idMP_dp = m.id_mate
GROUP BY p.id_ped, dp.idMP_dp, m.nombre_mate;
go
SELECT
	m.nombre_mate as [Materia Prima],
	dp.cantidad_dp as [Cantidad],
	dp.costo_unitario_dp as [Precio Prod],
	(dp.cantidad_dp * dp.costo_unitario_dp) AS [SubTotal]
FROM DETALLE_PEDIDO dp
	INNER JOIN MATERIAL m ON dp.idMP_dp = m.id_mate
GROUP BY m.nombre_mate, dp.cantidad_dp, dp.costo_unitario_dp