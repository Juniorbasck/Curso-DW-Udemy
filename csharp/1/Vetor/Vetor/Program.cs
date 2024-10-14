using System;
using System.Globalization;

namespace Vetor
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
            int n = int.Parse(Console.ReadLine());

            double[] vect = new double[n]; 

            for (int i = 0; i < n; i++) { 

                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            }

            Console.WriteLine();
            Console.WriteLine("vetor: ");

            foreach (double value in vect)
            {
                Console.WriteLine(value.ToString("F2", CultureInfo.InvariantCulture));
            } 

            Console.WriteLine("");
            Console.WriteLine("");

            double sum = 0.0;

            for (int i = 0; i < n; i++) 
            {
                sum += vect[i];
            }

            double avg = sum / n;

            Console.WriteLine("resultado: " + avg);
        }
    }
}