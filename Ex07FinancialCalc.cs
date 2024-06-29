using System;

namespace financialcalici{
    class Emi{

        public double CalculateEMI(double priciple,double interestrate, int termInYears){
            double monthlyintrestRate = interestrate / (12*100);
            int totalmonths = termInYears*12;
            
            double emi = priciple*monthlyintrestRate*Math.Pow(1 + monthlyintrestRate,totalmonths) / (Math.Pow(1+monthlyintrestRate,totalmonths)-1);
           return emi;
        }

        public void displayEMI(double priciple  ,double interestrate,int termInYears){
            double emi = CalculateEMI(priciple,interestrate,termInYears);
            System.Console.WriteLine("the total EMI for u would be = "+emi);
            System.Console.WriteLine("the one month intrest rate is= " + (interestrate/12));
            System.Console.WriteLine("total month u are paying = " +(termInYears*12));
        }
    }
        // A = P {( 1 + R/N)} ^ (N * t) 
    class RDamount{

        public double Calculaterdammount(double priciple,double interestrate, int termInYears){

            double monthlyintrestRate = interestrate / (12*100);
            int totalmonths = termInYears*12;
            double rdamountt = priciple* ((Math.Pow(1+monthlyintrestRate,totalmonths)-1)/monthlyintrestRate);
            // System.Console.WriteLine("the total RD ammount for u is" +rdamountt);
            return rdamountt;

        }

        public void displayRd(double priciple  ,double interestrate,int termInYears){

                double rdamountt = Calculaterdammount(priciple,interestrate,termInYears);
                System.Console.WriteLine("the final amount u are paying is" +rdamountt);
                System.Console.WriteLine("the total months u are paying" +(termInYears*12));
                // int month = 30*interestrate
                // System.Console.WriteLine("nt u are paying the monthly amou");
        }

    }
    
    
    class calculator{
        static void Main(string[] args)
        {
            System.Console.WriteLine("-----------welcome to the calculator---------------------");
            do{
           
            System.Console.WriteLine("enter the priciple amount you want to pay");
            double principle = double.Parse(Console.ReadLine());

            System.Console.WriteLine("enter the interest in percentage ");
            double interestrate = double.Parse(Console.ReadLine());

            System.Console.WriteLine("enter the term for how much year su want to pay ");
            int termInYears = int.Parse(Console.ReadLine());

            System.Console.WriteLine("enter the calculator u want to use emi or RD");
            string calci = Console.ReadLine();

            
            if (calci == "EMI"){
                Emi emicalculator= new Emi();
                emicalculator.displayEMI(principle,interestrate,termInYears);
            }
            else if (calci =="RD"){
                RDamount rdd = new RDamount();
                rdd.displayRd(principle,interestrate,termInYears);
            }
            else{
                System.Console.WriteLine("it is not implemented yet");
            }
            }while(true);
                
        }
    }
}