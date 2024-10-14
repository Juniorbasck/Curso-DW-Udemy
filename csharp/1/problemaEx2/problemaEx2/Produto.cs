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

        private string  Nome { get; private set; }

        private double Preco { get; private set; }

        private int Quantidade { get; set; }

        public Produto()
        {

        }

        public Produto(string nome, double preco, int quantidade) : this()
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        } 

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade = quantidade + quantidade;
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
