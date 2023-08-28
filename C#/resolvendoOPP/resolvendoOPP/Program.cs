//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using resolvendoOPP;
using System;
using System.Globalization;

namespace PrimeiroProjeto // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Triangulo x, y; 

            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas: ");

            x.A = double.Parse(Console.ReadLine());
            x.B = double.Parse(Console.ReadLine());
            x.C = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com as medidas: ");

            y.A = double.Parse(Console.ReadLine());
            y.B = double.Parse(Console.ReadLine());
            y.C = double.Parse(Console.ReadLine());

            double p = (x.A + x.B + x.C) / 2.0;
            double areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));

            p = (y.A + y.B + y.C) / 2.0;
            double areaY = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));

            Console.WriteLine("Area de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));

            Console.WriteLine("Area de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaX)
            {
                Console.WriteLine("Maior area: X");
            }
            else
            {
                Console.WriteLine("Maior ara Y");
            }
        }
    }
}