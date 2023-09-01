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

        public string Nome
        {
            get { return _nome; }
            set { if (value != null && value.Length > 1){
                    _nome = value;
                }  
            }
        }

        public double Preco
        {
            get { return _preco; } 
        }
      
        public int Quantidade
        {
          get { return _quantidade;  }

        }

        public double ValorTotalEmEstoque()
        {
            return _preco * _quantidade;
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
