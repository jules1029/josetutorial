-- --leaves comments in sql server
--the whole point of sql is to store your data in a way that has data integrity
--meaning that your data does not become corrupted or unusable

-- sql has datatypes just like code
--smallint 
--int 
--bigint (long) in code
--bit (0 or 1) this is for true/fale values
--char which is for characters (must always be the number specified
--vchar variable number of characters
--nvarchar variable number of characters can use non-ascii characters
--date date types

create table dbo.Users 
(
	Id bigint not null identity(1,1) primary key,
	UserName varchar(500) not null unique,
	FirstName varchar(500) not null,
	CreateDate datetime not null,
	State char(2) not null,
	IsActive bit not null,
	NickName varchar(500) null
);

drop table dbo.Users;

--Id name of the column
----bigint is the data type of the Id column so the column holds whole numbers that
----not null means the column can not have null values (so attempting to insert a null value will fail)
----AUTO_INCREMENT means everytime this row gets inserted into increment the value by one and store it (in sql server this is with identity(1,1) which means start the first value as 1 and increment by 1 each new record)

--UserName column
--varchar means it can have a any number characters up to 500

--State column
--Must always have 2 characters when inserting

--primary key very very important
--is a constraint. Every table must have 1 primary key
--The values in the primary key musth all be unique. 
--The primary key gets indexed by default for querying
--Index is similar in concept to an index in a book. Highly queried columns get put in a specific way to be read faster

--Unique constraint
--It doesn't make sense for two users to have the same username. So we can put unique keyword to force every value to be unique
