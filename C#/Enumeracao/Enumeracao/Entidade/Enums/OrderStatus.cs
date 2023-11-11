using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeracao.Entidade.Enums
{
    enum OrderStatus : int
    {
        PendingPayment = 0,

        Processing = 1,

        Shupeed = 2,

        Deliverd = 4
    }
}
