-------STORED PROCEDURES------------------------------
--Pre parsed statements that are created  to be used frquently in ur front end application

--variable in sq;l server is defined using prefix @

create procedure CreateEmployee
(
		@ename varchar(50),
		@eaddress varchar(200),
		@esalary money,
		@edept  int
) as

insert into EmpTable values(@ename,@eaddress,@esalary,@edept)
 
exec[dbo].CreateEmployee
        @ename ='Vipul',
		@eaddress ='Bangalore',
		@esalary =10000,
		@edept= 3 
GO
 
select * from EmpTable where empName='Vipul'
 
 -----------