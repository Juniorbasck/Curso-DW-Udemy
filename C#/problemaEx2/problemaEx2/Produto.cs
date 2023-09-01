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

        private string _nome;

        private double _preco;

        private int _quantidade;

        public Produto()
        {

        }

        public Produto(string nome, double preco, int quantidade) : this()
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }
        public double ValorTotalEmEstoque()
        {
            return _preco * _quantidade; 
        }

        public string Getnome()
        {
            return _nome;
        }

        public string SetNome(string nome)
        {
            return _nome = nome;
        }

        public double GetPreco()
        {
            return _preco;
        }


        public void AdicionarProdutos(int quantidade)
        {
            _quantidade = quantidade + quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            _quantidade -= quantidade;
        }
        
       
        public override string ToString()
        {

            return _nome + ", $ " + _preco
                + " , "
                + _quantidade
                + " unidades, total em estoque: $ " + ValorTotalEmEstoque();
        }
    }
}
