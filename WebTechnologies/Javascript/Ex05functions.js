//named functions in js.....
//1 st method to define a function
function addfunc(v1,v2){
    return (v1+v2);
}

//functions can be represented as variabels and used to creating anonymous methods in javascript
//2nd method to define a method
const subFunc= function(v1,v2){
    return v1-v2
}

//3 rd method to define a function

const mulfunc = (v1,v2)=>v1*v2;
const divfunc=(v1,v2)=>v1/v2;


// const v1 = parseFloat(prompt("enter the fisrt number"));
// const v2 = parseFloat(prompt("enter the second number"))
// const num = addfunc(v1,v2);
// console.log(num);

// result = subFunc(130,12);
// console.log(result)

// result = mulfunc(44,2);
// console.log(result)