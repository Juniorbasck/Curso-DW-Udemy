// See https://aka.ms/new-console-template for more information

using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

 
            int idade = 32;
            double saldo = 10.35523;
            string nome = "Maria";

            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome, idade, saldo);

            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais");

            Console.WriteLine("----------------");

            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reias");

        }
    }
}