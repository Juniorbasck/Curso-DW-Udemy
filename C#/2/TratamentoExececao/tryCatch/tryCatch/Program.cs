using System;
using System.Runtime.InteropServices;

class Trycatch{
    static void Main(string[] args)
    {
        try
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            int result = n1 / n2;
            Console.WriteLine(result);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Não é possivel dividir por zero");
        }
        catch(FormatException e)
        {
            Console.WriteLine("Formart error" + e.Message);
        }
    }
}