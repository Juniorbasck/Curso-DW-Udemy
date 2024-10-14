using problemaEx2;
using System;
using System.Threading.Channels;
using System.Globalization;

namespace Course
{
    class program
    {
        static void Main(string[] args)
        {

           Produto p = new Produto("TV",500.00, 10);


            Console.WriteLine(p.Getnome);

            p.SetNome("T23");

            Console.WriteLine(p.GetPreco());
        }
    }
}