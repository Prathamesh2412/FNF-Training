using System;

namespace SampleConApp
{		
	class sampleExample{
		static void display(){
			Console.WriteLine("hello world");
			Console.WriteLine("my name is prathamesh");
			Console.WriteLine("i am from bidar");
			Console.WriteLine("i work on .NET");
			Console.ReadLine();
			}

		static void inputExample(){
			Console.WriteLine("enter your Name");
			string name = Console.ReadLine();

			Console.WriteLine("enter your age");
			int  age = int.Parse(Console.ReadLine());

			Console.WriteLine("enter your phone number");
			string phone= Console.ReadLine();

			Console.WriteLine("the name is {0} with contacts {1} and the  age {2}",name,age,phone);

			Console.WriteLine("mr.{0}'s age will be {1} after 15 years",name,(age+15));
			
		}
		static  void Main(){
			//display();
			inputExample();
			}
		}
}
