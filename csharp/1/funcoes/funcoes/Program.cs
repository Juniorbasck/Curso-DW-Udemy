using System;

namespace Course
{
    class program
    {   
        static void Main(string[] args)
        {

            Console.WriteLine("Digite três numeros:");

            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            double reusltado = Maior(n1,n2, n3);

            Console.WriteLine("Maior = " + reusltado);
        }

        static int Maior(int a, int b, int c)  {
            int m;
            if (a > b && a > c)
            {
                m = a;
            }
            else if (b > c)
            {
                m = b;
            }
            else
            {
                m = c;
            }
            return m;
       
        }
    }
}