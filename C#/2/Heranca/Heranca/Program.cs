using Heranca.Entities;

namespace Heranca
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Acount acc = new Acount(1001, "Alex", 0.0);
            BusinessAcount bacc = new BusinessAcount(1002, "Maria", 0.0, 500.0);


            //UPCASTING 

            Acount acc1 = bacc;
            Acount acc2 = new BusinessAcount(1003, "Bob", 0.0, 200.0);
            Acount acc3 = new BusinessAcount(1004, "Anna", 0.0, 0.01);


            //DOWNCASTING

            BusinessAcount acc4 = (BusinessAcount)acc2;
            acc4.Loan(100.0);


            //BusinessAcount acc5 = (BusinessAcount)acc3;

            if (acc3 is BusinessAcount)
            {
                BusinessAcount acc5 = (BusinessAcount)acc3;
                acc5.Loan(200.0);
                Console.WriteLine("Loan!");
            }
        }    
    }
}