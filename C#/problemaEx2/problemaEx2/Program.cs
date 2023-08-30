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

            Produto p = new Produto();

            Console.WriteLine("Entre com os dados do produto: ");

            Console.Write("nome: ");

            p.nome = Console.ReadLine();

            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());


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