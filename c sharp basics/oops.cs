//----interface
using System;

namespace Sample
{
    interface Ivehicle
    {
        void startengine();
    }
    
    class Car : Ivehicle{
        public void startengine(){
            System.Console.WriteLine("car start");
        }
    }

    class bicycle : Ivehicle{
         public void startengine(){
            System.Console.WriteLine("bicycle start");
        }      
    }
    class program{
        static void Main(string[] args)
        {
            Ivehicle mycar = new car();
            Ivehicle bicycle = new bicycle;
            mycar.startengine();
            bicycle.startengine();
        }
    }   
}

//------inheritens


using System;
namespace program{
    class vehicle{
        public string name{get; set;}

        public void tirename(){
            System.Console.WriteLine("the name is ");
        }
    }

    class properties:vehicle{
        public string model { get; set;}
        public void insurense(){
            System.Console.WriteLine("hhk sjbkjb");
        }


    class program{
        static void Main(string[] args)
        {
            properties hello = new properties{name="prathamesh",model="baleno"};
            hello.tirename();
            hello.insurense();
            System.Console.WriteLine("the name is {0} and the model is{1}",hello.name,hello.model);    
        }
    }
    }
}


//---------------Abstraction

using System;

namespace sampleapp{
    abstract class shape{
        public string Name{get; set;}

        public abstract double Area();
        public abstract double perimeter();
    }

    class circle : shape{
        private double Radius{get; set;}

        public circle(double radius){
            Name = "circle";
            Radius = radius;
        }

        public override double Area(){
            return 3.14 * Radius*Radius;
        }

        public override double perimeter(){
            return 2*Math.PI*Radius;
        }
    }
    class rectangle : shape{
        public double Length{get; set;}
        public double Breadth {get; set;}

        public rectangle(double length,double breadth){
            Name="rectangle";
            Length=length;
            Breadth = breadth;
        }
        public override double Area(){
            return Length*Breadth;
        }
        public override double perimeter(){
            return 2*(Length+Breadth);
        }

        class program{
            static void Main(string[] args)
            {
               shape display = new rectangle(4,5);
               shape displayy = new circle(4);
               System.Console.WriteLine("the area is{0} and the perimeter is{1}",display.Area(),display.perimeter());
               System.Console.WriteLine("the area is {0} and the perimeter is{1}", displayy.Area(),displayy.perimeter());
            }
        }
    }
}