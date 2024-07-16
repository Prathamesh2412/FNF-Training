let v1 = prompt("enter the fisrt value");
//isNAN(not a number) is a global function
if(isNaN(v1)){
    alert("the number is not a valid so taking 0");
    v1=0;
}else{
   v1 = parseFloat(v1);
}
let v2 = prompt("enter the second value");
if(isNaN(v2)){
    alert("the number is not a valid so taking 0");
    v2=0;
}
else{
    v2 =parseFloat(v2);
}
let op = prompt("enter the choice as +,-,*,%");

switch(op){
    case "+":
        alert("the result of cohice is "+(v1+v2));
    break;
    case "-":
        alert("the result of cohice is "+(v1-v2));
    break;
    case "*":
        alert("the result of cohice is "+(v1*v2));
    break;
    case "/":
        alert("the result of cohice is "+(v1/v2));
    break;
    default:
        alert("unrecognized choice");
        break;
}