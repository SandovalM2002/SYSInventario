use InventarioSYS
go
--CREATE TABLE MRP
--(
--	id_MRP int identity(1,1) primary key not null,
--	id_nodo int foreign key references Nodo(id_nodo) not null,
--);
--go
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
SELECT * FROM MRP
SELECT * FROM DETALLE_MRP