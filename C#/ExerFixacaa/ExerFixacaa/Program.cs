using System.Threading.Channels;

namespace ExerFixacaa
{
    internal class Program
    {   
        static void Main(string[] args)
        {
             
            ContaBancaria conta;

            Console.Write("Entre com o numero da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            string tiular = Console.ReadLine();

            Console.Write("Haverá depósito incial (S/N)? ");
            char resp = char.Parse(Console.ReadLine());

            if (resp == 's' || resp == 'S')
            {
                Console.WriteLine("Entre o valor de depósito inicial: ");
                Double depositoInical = double.Parse(Console.ReadLine());

                conta = new ContaBancaria(numero, tiular, depositoInical);
            }
            else
            {
                conta = new ContaBancaria(numero, tiular);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(conta);
        }
    }
}