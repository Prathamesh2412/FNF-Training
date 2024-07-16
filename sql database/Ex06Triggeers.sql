--------------------triggers are events that is enovoked automatically when a condition is met(insert,delete,update)

create table customer
(
	CstId int primary key identity(1,1),
	CstName varchar(50) NOt Null,
	CstAddress Varchar(200) not null,
	BillDate Date Default GetDate(),
	BillAmount money,
)

create table Customer_Audit
(
	id int primary key identity(1,1),
	description varchar(200) NOT NULL,
)

--------------------------------INSERTION TRIGGER----------------------------------------

alter trigger OnNewCustomer
on customer
for insert
as
begin
declare @id int
select @id=cstid from inserted
declare @desc varchar(200)
declare @name varchar(200)
select @name =cstname from inserted
set @desc='Customer with ID'+cast(@id as varchar(4))+'and name as'+@name+'Inserted Successfully on'+
dbo.CreateDate(getdate())
insert into customer_Audit values (@desc)
end


insert into customer(CstName,CstAddress,BillAmount) values ('Prathamesh','Bhalki',546)

select * from Customer_Audit;

-------------------update trigger-------------------------

create trigger OnUpdateCustomer
on customer
AFTER update
as
begin
DECLARE @id int
Declare @oldname varchar(50)
Declare @newname varchar(50)
select @id = CstId from inserted
select @newName = CstName from inserted
select @oldname = CstName from inserted
insert into Customer_Audit values('the Customer with id'+CAST(@id as varchar(4)) + 'has been updated with the name as'+ @newname +
'for the old name' + @oldname+ 'on' +dbo.createDate(GetDate()))
end

update customer
set CstName ='Prathamesh p' where CstName='Prathamesh'
select * from Customer_Audit

