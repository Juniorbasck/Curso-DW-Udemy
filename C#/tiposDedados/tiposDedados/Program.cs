// See https://aka.ms/new-console-template for more information

using System;

namespace tiposDedados // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            Boolean completo = false;
            char genero = 'F';
            char letra = '\u0041';
            byte n1 = 126;
            int n2 = 1000;
            int n3 = 2147483647;
            long n4 = 2147483648L;
            float n5 = 4.5f;
            double n6 = 4.5;
            string nome = "Maria green";
            object obj1 = "Alex Brown";
            object obj2 = 4.5f;

            int a1 = int.MinValue;
            int a2 = int.MaxValue;
            sbyte a3 = sbyte.MinValue;
            decimal a4 = decimal.MaxValue;

            Console.WriteLine(a1);
            Console.WriteLine(a2);


            Console.WriteLine(completo);
            Console.WriteLine(genero);
            Console.WriteLine(letra );
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(nome);
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);
        }
    }
}