--now we need to add some data to your table
insert into dbo.Users (UserName, FirstName, CreateDate, State, IsActive, NickName) 
values ('jose.mel', 'Jose', GETDATE(), 'TX', 1, null);

--insert into {table name} tells sql which talbe you would like to put data into
--the parentheses immediately after contain all the column names you would like to insert into
--values keyword followed by a list of values to insert into thet able (must match your column name list)

--technically you can just insert without the into but it overwrites everything in the table
--insert = overwrite
--insert into = append

--if you have all the columns in the values that are in your table (minus AUTO_INCREMENT or identity columns) then you don't need to specify column name
insert into dbo.Users
values ('jules.m', 'Jules', GETDATE(), 'TX', 1, null);


