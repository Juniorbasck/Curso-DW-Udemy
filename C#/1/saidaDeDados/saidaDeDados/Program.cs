// See https://aka.ms/new-console-template for more information

using System;
using System.Globalization; 

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            //console.write não quebra linha 
            //já cosole.writeline quebra a linha

            char genero = 'F';
            int idade = 32;
            double saldo = 10.35523;
            string nome = "Maria";
            

            Console.Write("Bom dia");
            Console.WriteLine("Boa tarde");
            Console.WriteLine("___________________");
            Console.WriteLine(genero);
            Console.WriteLine(idade); 
            Console.WriteLine(saldo.ToString("F2"));
            Console.WriteLine(nome);
            Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture)); //para deixar com um ponto invez de virgula
        }
    }
}
