--different types of relationships in sql

--1 to 1
--1 to many
--many to many

--Address example was 1 to many. 1 user can have many address

--Many users can purchase many products

create table dbo.Users
(
	Id bigint not null IDENTITY(1,1) primary key,
    UserName varchar(200) not null
);

create table dbo.Product
(
	Id bigint not null IDENTITY(1,1) primary key,
    ProductName varchar(200) not null
);

--xref (cross reference) table
create table dbo.UsersProduct
(
	Id bigint not null IDENTITY(1,1) primary key,
    UsersId bigint not null,
    ProductId bigint not null,
    CONSTRAINT fk_usersid FOREIGN KEY (UsersId) REFERENCES Users(Id),
    CONSTRAINT fk_productid FOREIGN KEY (ProductId) REFERENCES Product(Id)
);

insert into dbo.Users values (1, 'jose');
insert into dbo.Users values (2, 'jules');
insert into dbo.Users values (3, 'alex');

insert into dbo.Product values (1, 'swiffer');
insert into dbo.Product values (2, 'broom');
insert into dbo.Product values (3, 'car');

--so we have users 1,2,3 and products 1,2,3
--lets say user 1 buys products 2 and 3
--and user 2 buys product 1 and 3

--user 1
insert into dbo.UsersProduct values (1, 1, 2);
insert into dbo.UsersProduct values (2, 1, 3);

--user 2
insert into dbo.UsersProduct values (3, 2, 1);
insert into dbo.UsersProduct values (4, 2, 3);

select * from dbo.UsersProduct;

--first we join users to usersproducts based on the foreign key betwen Users.Id and UsersProducts.UserId
--then we join UsersProducts to Product based on the foreign key Product.Id and UsersProducts.ProductId
select * from dbo.Users u
inner join dbo.UsersProduct up on up.UsersId = u.Id
inner join dbo.Product p on p.Id = up.ProductId
where u.Id = 1 