CREATE TABLE Foods (
	IdFood int primary key identity,
	NameFood varchar(50)
)
GO

INSERT INTO Foods(NameFood)
VALUES('HAMBURGUER'),
	  ('REFRIGERANTE'),
	  ('BATATA FRITA')
GO

CREATE TABLE Orders (
	IdOrder int primary key identity,
	ClientName varchar(40)
)

GO

CREATE TABLE Orders_Itens(
	Id int primary key identity,
	OrderId int foreign key references Orders(IdOrder)
	FoodId  int foreign key references Foods(IdFood)
	Quantity int
)
GO

CREATE TABLE TempOrders(
	Id int primary key identity,
	Orders_ItensId int foreign key references Orders_Itens(Id)
)