using System;
// A class is closed for modification
class BaseClass{
    public virtual void TestFunc(){
        System.Console.WriteLine("test func from base ");
    }
}

// if u want to modify a method of the class u should go for inheritence. The base class method must be virtual if u want to override
//(change) the method.

class DerivedClass : BaseClass{
    public override void TestFunc(){
        System.Console.WriteLine("Test func from Derived ");
    }
    public  void Nonoverridablefunc(){
        System.Console.WriteLine("this func is from the base only");
    }
}

class ClassFactory{
    public static BaseClass Createobject(string choice){
        if(choice=="Base") return new BaseClass();             
        else if(choice == "Derived") return new DerivedClass();
        else throw new Exception("Invalid choice of class");
    }
}
class MainClass{
    static void Main(string[] args)
    {
        
    }
}