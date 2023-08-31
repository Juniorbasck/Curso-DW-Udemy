using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static double Pi = 3.14;
        static void Main(string[] args)
        {

            Console.WriteLine("Entre com o valor: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double Circ = Circuferencia(raio);
            double volume = Volume(raio);

            Console.WriteLine("Circuferencia: " + Circ);
            Console.WriteLine("Circuferencia: " + Circ);
            Console.WriteLine("Valor de PI: " + Pi);
        }

        static double Circuferencia(double raio)
        {
            return 2.0 * Pi * raio;
        }

        static double Volume( double raio)
        {
            return 4.0 / 3.0 * Pi * Math.Pow(raio, 3);
        }
    }
}
