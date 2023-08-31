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

           

        
            Console.WriteLine("Entre com os dados do produto: ");

            Console.Write("nome: ");

            string nome = Console.ReadLine();

            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

           

            Produto p = new Produto(nome, preco);

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);
            Console.WriteLine();

            Console.WriteLine("Digite o numero de produto a serem add");

            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);


            Console.WriteLine("Dados Atulizados: " + p);

            Console.WriteLine("Type the number of products to be delete of stock");

            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);


            Console.WriteLine("Dados Atulizados: " + p);
       
        }
    }
}