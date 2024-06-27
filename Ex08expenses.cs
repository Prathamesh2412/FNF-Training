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
                Console.WriteLine($"Expense Found: ID = {expense.Id}, Description = {expense.Description}, Amount = {expense.Amount}, Date = {expense.Date.ToShortDateString()}");
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
