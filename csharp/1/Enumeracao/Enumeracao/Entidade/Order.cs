using Enumeracao.Entidade.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeracao.Entidade
{
    internal class Order
    {

        public int Id { get; set; }

        public DateTime Moment { get; set; }

       public OrderStatus Staus { get; set; }

        public override string ToString()
        {
            return Id
                + ", "
                + Moment
                + ", "
                + Staus;
        }
    }
}
