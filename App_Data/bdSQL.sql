--CREATE table clientes(
--	idcli INT IDENTITY PRIMARY KEY,
--	nomecli NVARCHAR(50) NOT NULL,
--	categoria NVARCHAR(50) 
--		CHECK(categoria = 'alfa' OR categoria ='bravo' OR categoria='charlie'),
--	fotopath nvarchar(255)

--);


--insert into clientes (nomecli, categoria)
--VALUES	('Tio Patinhas', 'alfa'),
--		('Margarida', 'bravo'),
--		('Peninha', 'alfa'),
--		('Pato Donald', 'charlie');

--select * from clientes;