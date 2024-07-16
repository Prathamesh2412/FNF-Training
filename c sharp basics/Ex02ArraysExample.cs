//Ex02ArraysExample.cs

using System;

    namespace SampleConApp{
        class Ex02aArraysexample{
            static void baicarrayexample(){
                Console.WriteLine("eneter the size of the array");
                int size = int.Parse(Console.ReadLine());
                
                int[] elements = new int[size];
                for (int i =0;i<size; i++){
                    Console.WriteLine("enter the values at position {0}",i);
                    elements[i] =int.Parse(Console.ReadLine());
                }
                Console.WriteLine("all the values are set");
                foreach(var item in elements){
                    Console.WriteLine(item);
                }
            }
            static void creatingarrayatruntime(){
                Console.WriteLine("enter the size of array");
                int  size= int.Parse(Console.ReadLine());
                
                Console.WriteLine("enter the cts type for the type of array");
                Type arrayType = Type.GetType(Console.ReadLine());
                if (arrayType==null)
                {
                    Console.WriteLine("not a valid datatype of .NET");
                    return;
                }
                Array array = Array.CreateInstance(arrayType,size);
                for (int i =0; i<size; i++){
                    Console.WriteLine("eneter the value for the position {0} of the type{1}",i,arrayType.FullName);
                    object value = Convert.ChangeType(Console.ReadLine(), arrayType);
                    array.SetValue(value,i);
                }
                Console.WriteLine("all the values are set lets read this");
                foreach(var item in array)
                {
                    Console.WriteLine(item);
                }
            }
            static void Main(string [] args){
                //baicarrayexample();
                creatingarrayatruntime();
                
                
            }
        }
    }