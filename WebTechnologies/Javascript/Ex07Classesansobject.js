//singleton objects 
const emp ={
    empName:"Prathamehs",
    empAddress :"Banglore",
    empsalary :56000,
}


console.log(emp); 

const emp2=emp;

emp2.empsalary=15000;
console.log(emp.empsalary);
console.log(emp2.empsalary);

for(const key in emp){
    console.log(`Property:${key}, value: ${emp[key]}`);
}

//...it is called as spread operator using this we can append an object with current object data and adding with additional attributes
const emp3 = {...emp,empDesignation:"Trainee"}
console.log(emp3);

//////////////////////////  CREATING MULTIPLE OBJECTS  //////////////////////////////////////////////
const employee = function(id,name,address){
    this.empID= id;
    this.empName=name;
    this.empAddress =address;
    this.display =function(){
        return `${this.empName} is from ${this.empAddress}`
    }
}

const employee1=new employee(123,"Prathamesh","banglore");
const employee2 = new employee(433,"Binod","Pune")
alert(employee2.display())

console.log(employee1.empAddress)
console.log(employee2.empAddress)

//////////////////////////////////////////////////////////////////////////////////////////////////////////
class customer{
    constructor(id,name,address,bill){
        this.id = id;
        this.name=name;
        this.address=address;
        this.billAmount=bill
    }
    display=()=>`${this.name} is from ${this.address} and has raised the bill amount of RS. ${this.billAmount}`
}
const cst =new customer(123,"suresh","Banglore",5000)
alert(cst.display())