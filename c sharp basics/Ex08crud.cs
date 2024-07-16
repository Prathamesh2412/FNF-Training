// using System;
// using System.Collections.Generic;
// using System.Linq;

// namespace Samplecon{
//     class Expense{
//         public int ID  {get; set;}
//         public string Description  {get; set;}
//         public double Amount {get; set;}
//         public DateTime Date {get; set;}

//         public override string ToString(){
//             return string.Format("the Id is {0} and the Description is {1} the ampont payed is {3} and the date bougnt is {4:dd-mm-yyyyy}"
//             ,this.ID,this.Description,this.Amount,this.Date);

//         }
//     }

    // class display{
    //     static void Main(string[] args)
    //     {
    //     //    Expense report = new Expense{ID=767, Description = "this is about c sharp",Amount = 999};
    //     //    System.Console.WriteLine("the id is {0} , \n the description i s{1} \n the Amount is {2}\n, the date is  \n"+ report.ID,report.Description,report.Amount);

    //        Expense details = new Expense();
    //        details.ID = 878;
    //        details.Description = "c sharp training";
    //        details.Amount = 1000; 
    //         details.Date  = DateTIme.Now;

    //        System.Console.WriteLine("the id is :\n"+ details.ID);
    //        System.Console.WriteLine("the description is :\n"+details.Description);
    //        System.Console.WriteLine("the amount is \n"+details.Amount);
    //        System.Console.WriteLine("the date is \n");           
    //     }
    // }

//     class expensecollection{

//             // public AddExpense {get; ,set;}
//             // public RemoveExpense {get; ,set;}
//             // public UpdateExpense {get; ,set;}
//             // public FindExpense {get; ,set;}

//         private List<Expense> Expenses = new List<Expense>();

//         public void AddExpense(Expense expense){

//                 Expenses.Add(expense);
//                 Console.WriteLine("Expense added succesfully");
//         }

//         public bool RemoveExpense(int id){
//             Expense expensetoRemove = Expenses.Find(e=> e.ID==id);
//             if (expensetoRemove !=null)
//             {
//                 Expense.Remove(expensetoRemove);
//                 System.Console.WriteLine("expense removed succesfully");
//                 return true;
//             }
//             System.Console.WriteLine("expense not found");
//             return false;
//         }
//         public bool updateexpense(int id,Expense newExpense){
//             Expense expensetoupdate= Expenses.Find(e=> e.ID==id);
//             if (expensetoupdate !=null)
//             {
//                expensetoupdate.Description = newExpense.Description;
//                expensetoupdate.Amount  = newExpense.Amount;
//                expensetoupdate.Date = newExpense.Date;
//                System.Console.WriteLine("expense added succesfully");
//                return true;
//             }
//             System.Console.WriteLine("expense cannot be find");
//             return false;
//         }
//         public Expense findExpense(int id){
//             return Expenses.Find(e=> e.ID==id);
//         }

//         public void displayallexpenses(){
//             System.Console.WriteLine("all expenses ");
//             foreach(var expense in expenses){
//                 System.Console.WriteLine(expense);
//             }
//         }
//     }

//     class program{
//         static void Main(string[] args)
//         {
//             Expensecollection expensecollection =new Expensecollection();

//             bool runnig =true;
//             while(runnig)
//             {
//                 System.Console.WriteLine("\n Expense manager");
//                 System.Console.WriteLine("1.Add Expense");
//                 System.Console.WriteLine("2.update Expense");
//                 System.Console.WriteLine("3.Remove Expense");
//                 System.Console.WriteLine("4.Find Expense");
//                 System.Console.WriteLine("5.Display Expense");
//                 System.Console.WriteLine("1.Exit");
//                 System.Console.WriteLine("enter your choice");
//                 int choice = int.Parse(Console.ReadLine());
//                 switch(choice){
//                     case 1:
//                     Expense newExpense = new Expense();
//                     System.Console.WriteLine("Enter ID: ");
//                     newExpense.ID = int.Parse(Console.ReadLine());
                    
//                     System.Console.WriteLine("Enter description: ");
//                     newExpense.Description = Console.ReadLine();

//                     System.Console.WriteLine("Enter Amount: ");
//                     newExpense.Amount = int.Parse(Console.ReadLine());

//                     System.Console.WriteLine("Enter Date: ");
//                     newExpense.Date = Console.ReadLine();

//                     expensecollection.AddExpense(newExpense);
//                     break;

//                     case 2:
//                     System.Console.WriteLine("enter the id of expense : ");
//                     int updateId = int.Parse(Console.ReadLine());

//                     Expense updatedExpense = newExpense();

//                     System.Console.WriteLine("enter the new description : ");
//                     updatedExpense.description = Console.ReadLine();

//                     System.Console.WriteLine("enter the new Amount");
//                     updatedExpense.Amount = int.Parse(Console.ReadLine());

//                     System.Console.WriteLine("enter the new date ");
//                     updatedExpense.Date = Console.ReadLine();

//                 }
//             }
//         }
//     }
    
// }








using System;
using System.Collections.Generic;

namespace SampleConApp
{
    class Expense
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public double Amount { get; set; }
        public DateTime Date { get; set; }
    }

    class Display
    {
        private List<Expense> expenses = new List<Expense>();

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Expense Sheet. Press the key to perform an operation");
            Display program = new Display();

            do
            {
                Console.WriteLine("1: Add Expense");
                Console.WriteLine("2: Update Expense");
                Console.WriteLine("3: Remove Expense");
                Console.WriteLine("4: Find Expense");
                Console.WriteLine("Enter your choice:");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        program.AddExpense();
                        break;
                    case 2:
                        program.UpdateExpense();
                        break;
                    case 3:
                        program.RemoveExpense();
                        break;
                    case 4:
                        program.FindExpense();
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();
            } while (true);
        }

        public void AddExpense()
        {
            Expense details = new Expense();

            Console.WriteLine("Enter the ID:");
            details.Id = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the description:");
            details.Description = Console.ReadLine();

            Console.WriteLine("Enter the amount:");
            details.Amount = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the date (yyyy-mm-dd):");
            details.Date = DateTime.Parse(Console.ReadLine());

            expenses.Add(details);
            Console.WriteLine("Expense added successfully.");
        }

        public void RemoveExpense()
        {
            Console.WriteLine("Enter the ID of the expense to remove:");
            int id = int.Parse(Console.ReadLine());

            Expense expense = expenses.Find(e => e.Id == id);
            if (expense != null)
            {
                expenses.Remove(expense);
                Console.WriteLine("Expense removed successfully.");
            }
            else
            {
                Console.WriteLine("Invalid ID. Expense not found.");
            }
        }
        public void FindExpense()
        {
            Console.WriteLine("Enter the ID of the expense to search:");
            int id = int.Parse(Console.ReadLine());

            Expense expense = expenses.Find(e => e.Id == id);
            if (expense != null)
            {
                Console.WriteLine("Expense Found: ID = {0}, Description = {1}, Amount = {2}, Date = {3}",expense.Id,expense.Description,expense.Amount,expense.Date.ToShortDateString());
            }
            else
            {
                Console.WriteLine("Invalid ID. Expense not found.");
            }
        }
        public void UpdateExpense()
        {
            Console.WriteLine("Enter the ID of the expense to update:");
            int id = int.Parse(Console.ReadLine());

            Expense expense = expenses.Find(e => e.Id == id);
            if (expense != null)
            {
                Console.WriteLine("Enter the new description:");
                expense.Description = Console.ReadLine();

                Console.WriteLine("Enter the new amount:");
                expense.Amount = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter the new date (yyyy-mm-dd):");
                expense.Date = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("Expense updated successfully.");
            }
            else
            {
                Console.WriteLine("Invalid ID. Expense not found.");
            }
        }
    }
}