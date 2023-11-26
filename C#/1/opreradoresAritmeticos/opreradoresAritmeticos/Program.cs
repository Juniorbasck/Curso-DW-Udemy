using System;
using System.Numerics;

namespace operadoresAri
{
    internal class prgram
    {
        static void Main(String[] args)
        {

            //int n1 = 3 + 4 * 2;

            //int n2 = (3 + 4) * 2;
            //int n3 = 17 % 3;

            //float n4 = (float) 10 / 8;  

            //Console.WriteLine(n1);
            //Console.WriteLine(n2);
            //Console.WriteLine(n4);


            //===========

            double a = 1.0, b = -3.0, c = -4.0;

            double delta = Math.Pow(b, 2.0) - 4.0 * a * c; 
            
            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);

            Console.WriteLine(delta);
            Console.WriteLine(x1);
        }
    }
}