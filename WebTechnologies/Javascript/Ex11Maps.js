
function mapExample(){
    const items = new Map();
        items.set("Apples",200)
        items.set("Mangoes",400)
        items.set("Grapes",50)
        items.set("pomegranate",100)

        console.log(items.has("Mangoes"))

        for(const pair of items){
            console.log(`Key:${pair}`);
        }
    }
//todo test the code in html page