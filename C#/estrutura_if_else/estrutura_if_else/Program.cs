using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            //int x = 10;

            //Console.WriteLine("Bom Dia");

            //if (x > 5) { 

            //    Console.WriteLine("Boa Tarde");

            //}

            //Console.WriteLine("Boa noite");

            //Console.WriteLine("entre com um numero inteiro");

            //int x = int.Parse(Console.ReadLine());

            //if (x % 2 == 0)
            //{
            //    Console.WriteLine("é par");
            //}
            //else{
            //    Console.WriteLine("impar");
            //}

            Console.WriteLine("Digite uma hora");
            int hora = int.Parse(Console.ReadLine());

            if (hora < 12)
            {

                Console.WriteLine("Bom Dia");

            }
            else if (hora <= 18)
            {

                Console.WriteLine("Boa tarde");

            }
            else
            {
                Console.WriteLine("Boa noite");
            }
        }
    }
}
