-------STORED PROCEDURES------------------------------
--Pre parsed statements that are created  to be used frquently in ur front end application

--variable in sq;l server is defined using prefix @

create procedure CreateEmployee
{
	@ename varchar(50),
	@eaddress varchar(200),
	@esalary money,
	@edept int
}
