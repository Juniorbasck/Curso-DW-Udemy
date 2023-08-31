using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace problemaEx2
{
    internal class Produto
    {

        public string Nome;

        public double Preco;

        public int Quantidade;

        public Produto()
        {
        }

        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public Produto(string nome, double preco) 
        {
            Nome= nome;
            Preco = preco;
            Quantidade = 5;
        }
        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade; 
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade = Quantidade + quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }

        public override string ToString()
        {

            return Nome + ", $ " + Preco
                + " , "
                + Quantidade
                + " unidades, total em estoque: $ " + ValorTotalEmEstoque();
        }
    }
}
