using System;
using System.Globalization;

namespace expressaoCondicional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double desconto = (preco < 20.0) ? preco * 0.1 : preco * 0.05; // expressao regular 

            //if (preco < 20.0)
            //{
            //    desconto = preco * 0.1;
            //}
            //else
            //{
            //    desconto = preco * 0.05;
            //}

            Console.WriteLine(desconto);
        }
}