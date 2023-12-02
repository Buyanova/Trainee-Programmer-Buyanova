Use [Products]

Create table Product
(
Id int Primary key Identity(1,1),
NameProduct nvarchar(100) not null
)
Insert into Product (NameProduct)
values ('Apple'), ('Doll'), ('Phone'), ('Mop')

Create table Category
(
Id int Primary key Identity(1,1),
IdProduct int not null,
NameCategory nvarchar(100)
Foreign key (IdProduct) references Product(Id) on update cascade on delete cascade
)

Insert into Category (NameCategory, IdProduct)
values ('Fruits', 1), ('Toys', 2), ('Gadgets', 3), (null, 4)

-- Запрос для выбора всех пар «Имя продукта – Имя категории»
select NameProduct as 'Name product', NameCategory as 'Name category' from Product p
inner join Category c on p.Id = c.IdProduct
