-----------------------using in clause-----------------------------

select * from EmpTable where empAddress='Pune' or empAddress = 'Lucknow' or empAddress='Hydrabad'

--short hand for multiple or ans ands u should go for in clause

select * from EmpTable where empAddress in('Pune','Lucknow','Hydrabad')

------------------------------Having clause--------------------------------------
--similar to where clause but it is used with group by and aggregate functions
--it is used before groupby and before orderby clause
--find all dept whose sum of salaries has more than 4 lakhs

select dbo.getDeptName(EmpTable.DeptId) as dept,sum(EmpTable.empSalary)
from EmpTable
group by DeptId
having sum(empSalary)> 2000;
