using System;
using System.Net;

namespace escopo
{
    class Program 
    { 
       static void Main(string[] args)
        {

            var x;

            Console.WriteLine(x);
            //sempre inicializar variaveis 

            double preco = double.Parse(Console.ReadLine());

            if (preco > 100.0)
            {
                double desconto = preco * 0.1;
            }

            Console.WriteLine(desconto);
            //tomar cuidado com o escporto das variaveis 
        }
    }
}