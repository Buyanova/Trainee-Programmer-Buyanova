Use [��������]

Create table �������
(
Id int Primary key Identity(1,1),
���_�������� nvarchar(100) not null
)
Insert into ������� (���_��������)
values ('������'), ('�����'), ('�������'), ('������')

select * from �������

Create table ���������
(
Id int Primary key Identity(1,1),
IdProduct int not null,
���_��������� nvarchar(100)
Foreign key (IdProduct) references �������(Id) on update cascade on delete cascade
)

Insert into ��������� (���_���������, IdProduct)
values ('������', 1), ('�������', 2), ('�������', 3), (null, 4)

select * from ���������

select ���_��������, ���_��������� from ������� p
inner join ��������� k on p.Id = k.IdProduct
