--updating existing data

update dbo.Users
set FirstName = 'fuck';

--sets every rows FirstName column to fuck

update dbo.Users
set FirstName = 'hi'
where id = 1;

--sets the rows with id 1 to Hi