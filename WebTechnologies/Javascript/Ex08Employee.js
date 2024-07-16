class Employee{
    constructor(id,name,address,salary)
    {
        this.EmpID=id;
        this.EmpName=name;
        this.EmpAddress=address;
        this.Empsalary=salary;
        this.display =function(){
            return `${this.EmpID} name is ${this.EmpName} and he is from ${EmpAddress} and has a salary${Empsalary}`
        }
    }

}

class EmployeeRepo{
    data=[];
//called as spread operator this.data.push(emp)
constructor(){
    this.loadData()
}

loadData=()=>{
    const value= localStorage.getItem("empList")
    if(value!=null){
        const json = localStorage.getItem("empList");
        this.data=JSON.parse(json);
    } 
}

saveData=()=>{
    const json = JSON.stringify(this.data);
        localStorage.setItem("empList",json);

}
    addNewEmployee=(emp)=> {
        this.loadData();
        this.data=[...this.data,emp];
        this.saveData();
    }

    deleteEmployee=(id) =>{
        this.loadData();
        let index = this.data.findIndex((e)=>e.EmpID==id);
        this.data.splice(index,1);//removing an element in js array
        this.saveData();
    }

    getallEmployee = () =>
        {
            this.loadData();
           return this.data;
        }

    updateEmployee = (id,emp)=>{
        this.loadData();
        let index = this.data.findIndex((e)=>e.EmpID==id);
        this.data.splice(index,1,emp)//removes the number of elements from the specific index and replaces it with the amp object
        this.saveData();
    }
}





//////////////////lobal Functions///////////////////////////////////////

//const hideElements =(...element) =>[...element].forEach(e=>(e.style.display="none"));

//document.querySelectorAll('section')


const hide = function(elements){
    elements.forEach(element => {
        element.style.display="none"
    });
}

const show =(id)=> document.getElementById(id).style.display='block';