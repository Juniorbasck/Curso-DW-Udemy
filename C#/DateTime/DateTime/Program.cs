using System;
using System.Globalization;

namespace Datas
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DateTime d1 = new DateTime(2000, 8, 15);
            DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 58);
            DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58, 275);

            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);

            DateTime a1 = DateTime.Now;
            DateTime a2 = DateTime.UtcNow;
            DateTime a3 = DateTime.Today;

            Console.WriteLine(a1);
            Console.WriteLine(a2);
            Console.WriteLine(a3);


            DateTime x1 = DateTime.Parse("2000-08-15");
            DateTime x2 = DateTime.Parse("2000-08-15 13:05:58");
            DateTime x3 = DateTime.Parse("15/08/2000");
            DateTime x4 = DateTime.Parse("15/08/2000 13:05:58");

            Console.WriteLine(x2);
            Console.WriteLine(x3);
            Console.WriteLine(x1);
            Console.WriteLine(x4);


            DateTime z1 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd",
            CultureInfo.InvariantCulture);

            DateTime z2 = DateTime.ParseExact("15/08/2000 13:05:58", "dd/MM/yyyy HH:mm:ss",
            CultureInfo.InvariantCulture);

            Console.WriteLine(z1);
            Console.WriteLine(z2);
        }
    }
}