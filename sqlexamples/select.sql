--reading data from an existing database
--I've inserted my data now what?

select * from dbo.Users;

--select means to select the data * means all columns from {table name} means read them all from that table

select Id, State from dbo.users;

--you can also speicify coluns you would like to select

select * from dbo.users where id >= 1;

--you can specify a where clause to limit the data you are returning

select * from dbo.users where id > 1 and username = 'jules.m';

select * from dbo.users where username like 'j*';

select * from dbo.users where id <> 1;
--<> is for not equals

select * from dbo.users where NickName is null;
select * from dbo.users where NickName is not null;
--unlike c-- where things can equal null in sql they can't so you have to use is null or is not null to check for it


