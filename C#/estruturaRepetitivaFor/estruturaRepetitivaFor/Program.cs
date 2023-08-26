using System;

namespace Course
{
    class program
    {
        static void Main(string[] args)
        {

            Console.Write("Quanto numero inteiro vc vai digitar?");
            int n = int.Parse(Console.ReadLine());

            int soma = 0;

            for (int i = 0; i <= n; i++) 
            {
                Console.WriteLine("valor #{0}: ", i);
                int valor = int.Parse(Console.ReadLine());
                soma += valor;
            }

            Console.WriteLine("Soma igual: " + soma);
        }
    }
}