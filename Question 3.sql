Use [Продукты]

Create table Продукт
(
Id int Primary key Identity(1,1),
Имя_продукта nvarchar(100) not null
)
Insert into Продукт (Имя_продукта)
values ('Яблоко'), ('Кукла'), ('Телефон'), ('Швабра')

select * from Продукт

Create table Категория
(
Id int Primary key Identity(1,1),
IdProduct int not null,
Имя_категории nvarchar(100)
Foreign key (IdProduct) references Продукт(Id) on update cascade on delete cascade
)

Insert into Категория (Имя_категории, IdProduct)
values ('Фрукты', 1), ('Игрушки', 2), ('Гаджеты', 3), (null, 4)

select * from Категория

select Имя_продукта, Имя_категории from Продукт p
inner join Категория k on p.Id = k.IdProduct
