--Sql is an RDBMS (Relational Database Management System)
--Basically sql is for storing and reading relational (datasets that have relationships with eachother)

create table dbo.Users 
(
	Id bigint not null identity(1,1) primary key,
	UserName varchar(500) not null unique,
	FirstName varchar(500) not null,
	CreateDate datetime not null,
	IsActive bit not null,
	NickName varchar(500) null
);

create table dbo.Address
(
	Id bigint not null identity(1,1) primary key,
    UsersId bigint not null,
	City varchar(500) not null,
    Street varchar(500) not null,
    State char(2) not null,
    Zipcode char(5) not null,
    CONSTRAINT fk_usersid FOREIGN KEY (UsersId) REFERENCES Users(Id)
);

--Foreign Key is a unique column that points back to another table (creates relationship between it and that table
--all values in a foreign key column must exist in the parent table

insert into dbo.Users values (1, 'josem', 'jose', Now(), 1, null);

insert into dbo.Address values(1, 1, 'addison', 'asdf', 'tx', '75007');
insert into dbo.Address values(2, 1,  'plano', 'asdfee', 'tx', '75007');

select * from dbo.Users;
select * from dbo.Address;

--JOINS
--joins are for combinging to tables together

select * from dbo.Users u
inner join dbo.Address a on a.UsersId = u.Id
where u.id = 1;

--inner and outer joins
--inner join only returns where the two intersect (only where they match)
--outer join returns all results and will send back null where they don't match

drop table dbo.Address;
drop table dbo.Users;
