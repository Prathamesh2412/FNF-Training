const fruits=["apples","Mangoes","oranges"];
console.log(fruits);

// //using for loop
// for(let i = 0 ; i<fruits.length;i++){
//     console.log(i)
// }

// //for of loop same as foreach in c sharp

// for (const elemnt of fruits) {
//     console.log(elemnt);
// }

// //for in loop uses index for iterations and key is used for index

// for(const key in fruits){
//     console.log(`Index:${key}: value:${fruits[key]}`);
// }

// fruits.forEach((element)=>{
//     console.log(element);
// })

//push will add elemnts in the end of the list
fruits.push("pineapple");
fruits.push("custardapple");
fruits.push("banana");

//used to add element in the starting of the list
fruits.unshift("ananas")

//here 2 is used for index 0 is used for adding if we want to delete use 1 and the rayya elemts to add
//this is a methos used to remove insert replace elements in an array
fruits.splice(2,0,"gauva","banana","pomogranate")

for(const elemnt of fruits){
    console.log(elemnt)
}




