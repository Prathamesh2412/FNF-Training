using System;

namespace enumsexample{
    public enum AccountType
    {
        sbaccount,savingsaccount,fdaaccountg,caccount
    }
    class Ex03Enums{
        static void Main(string[] args)
        {
            enbumInputexample();
            // Console.WriteLine("Enter the type of account you want(sbaccount,savingsaccount)");           
            // string type = Console.ReadLine();
            // AccountType acc = type;
            // Console.WriteLine("the account selected is"+acc);
            // Console.WriteLine("the internal values of the enum is "+(int)acc);
        }
        static void enbumInputexample()
        {
            System.Console.WriteLine("please enter the account from the below list");
            var accountTypes = Enum.GetValues((typeof(AccountType)));
            foreach(var item in accountTypes){
                System.Console.WriteLine(item);
            }
            AccountType acc=(AccountType)Enum.Parse(typeof(AccountType),Console.ReadLine(),true);
            System.Console.WriteLine("the account type selected is :"+acc);
            
        }
    }

}

