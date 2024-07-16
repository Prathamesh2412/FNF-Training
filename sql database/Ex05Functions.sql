
CREATE FUNCTION getEmpCount()
RETURNS INT
AS
BEGIN
    DECLARE @count INT
    SET @count = (SELECT COUNT(*) FROM EmpTable)
    RETURN @count
END

select dbo.getEmpCount() as EmpCount

create Function getDeptName(@id int)
returns int
as
begin
	declare @deptName varchar(50)
	set @deptName = (select Deptname from DeptTable where DeptId=@id)
	return @deptName
	end

select empName, dbo.getDeptName(DeptId) as Dept from EmpTable;

----------------working woth datetime function--------------------------
PRINT GetDate()

CREATE Function CreateDate(@date date)
returns varchar(50)
as
begin
declare @retval varchar(50)
set @retval='' + cast(Day(@date) as varchar(5)) +'/'+cast(MONTH(@date) as varchar(20)) + '/'+ CAST(YEAR(@date) as varchar(4))
return @retval
end
print dbo.createDate(GetDate())


-----------------------------get the age for the given age-------------------------

create function getAge(@dob Date)
Returns int
as
begin 
declare @age int
set @age =DATEDIFF(YEAR,@dob,GETDATE())
return @age
end

print dbo.getAge('12/24/2002')

-------------------table value function-------------------------------

alter function getEmployeesByCity(@city varchar(50))
returns	 TABLE
AS
RETURN (SELECT * FROM EmpTable WHERE empAddress LIKE '%' + @city + '%')

select empName,empAddress from dbo.getEmployeesByCity('en')

select * from EmpTable


