
using System; 

namespace Course
{
    class program
    {
        static void Main(string[] args)
        {

            // a = 10  | a RECEBE 10;
            // A += 2  | a RECEBE a + 2;
            // a -= 2  | a RECEBE a - 2; 
            // a *= 2  | a RECEBE a * 2; 
            // a /= 2  | a RECEBE a / 2;
            // a %= 3  | a RECEBE a % 3; 
            //FUNCIONA COM STRING TBMMMM

            int a = 10;

            Console.WriteLine(a);

            a += 2;
            Console.WriteLine(a);

            string s = "ABC";
            Console.WriteLine(s);
            s += "DFC"; 
            Console.WriteLine(s);
        }
    }
}