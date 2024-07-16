setExample();


function setExample(){
        let set = new Set();
        set.add("item1");
        if(set.has("item1")){
            console.log("item already exists")
        }else{
            set.add("item1")
        }
        return set;
}