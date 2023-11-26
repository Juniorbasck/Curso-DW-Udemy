using System; 

namespace tiposDedados
{
    internal class prgram
    {
        static void Main(string[] args)
        {
            

            string frase = Console.ReadLine();
            string vermelho = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();

            string s = Console.ReadLine();

            string[] v = Console.ReadLine().Split(' ');
            string a = v[0];
            string b = v[1];
            string c = v[2];

            Console.WriteLine("vc diigitou:");
            Console.WriteLine(frase);
            Console.WriteLine(vermelho);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

        }
    }
}