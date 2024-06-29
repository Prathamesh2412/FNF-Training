using System;

namespace SampleConApp
{

    class Arithematic{
        public double FirstValue {get; set;}
        public double SecondValue {get; set;}
        public string Operation {get; set;}
        public double PerformOperation() {

            switch(Operation){
            case "+":
                return (FirstValue+SecondValue);
               
            case "-":
                return (FirstValue-SecondValue);
                
            case "*":
                return (FirstValue*SecondValue);
                
            case "/":
                return (FirstValue/SecondValue);
               
            default :
                throw new Exception("invalid choice");
        }

        }

    }
    class Ex06ProgrammingConcepts{

        static double PerformOperation(double first,double second, string operation){

            Arithematic math = new Arithematic();
            math.FirstValue = first;
            math.SecondValue = second;
            math.Operation = operation; 
            return math.PerformOperation();
        }
        static void Main(string[] args)
        {
            string stopsignal = "";
            System.Console.WriteLine("welcome to calculator");
            do{
            
            var first = MyConsole.GetDouble("enter first number ");

            var operation = MyConsole.GetString("enter the operation u want to perform ");
            
            var second = MyConsole.GetDouble("enter the second number ");

            
            try {
                double result = PerformOperation(first,second,operation);
                System.Console.WriteLine("the resilt is "+result);
                stopsignal = MyConsole.GetString("do u want to continue this operations? press Y for yes and N for no");
            }
            catch(Exception ex)
            {
                System.Console.WriteLine(ex);
            }
        
        }while(stopsignal.ToUpper()=="Y");
        }
    }
}