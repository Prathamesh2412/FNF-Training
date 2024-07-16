using System;


namespace SampleConApp{
    class Ex04Classesandobjects{
        static void Main(string[] args)
        {
           var sino= MyConsole.GetString("enter the si no of the laptop");
           
           var make= MyConsole.GetString("enter the make no of the laptop");
           
           var model=  MyConsole.GetString("enter the model no of the laptop");
           
           var price=  MyConsole.GetInteger("enter the price no of the laptop");
          
            var mymachine= new Machine{ Sino = sino, Make = make, Model = model, Price = price};
            System.Console.WriteLine(mymachine);
    }
}
    class Machine{
        public string Sino {get; set; }
        public string Make {get; set; }
        public string Model {get; set; }
        public int Price {get; set; }
        public override string ToString(){
            return string.Format("the sino: {0}\n the make:{1}, the model: {2}\n the pricetag: {3}",Sino,Make,Model,Price);
        }
    }  
}