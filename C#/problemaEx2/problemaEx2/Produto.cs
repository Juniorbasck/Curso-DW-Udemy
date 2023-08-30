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

        public string nome;

        public double Preco;

        public int Quantidade; 


        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade; 
        }
    }
}
