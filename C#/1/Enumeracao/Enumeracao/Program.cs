using Enumeracao.Entidade;
using Enumeracao.Entidade.Enums;

namespace Enumeracao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Order order = new Order 
            { 
                Id = 1232,
                Moment = DateTime.Now,
                Staus = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            string txt = OrderStatus.PendingPayment.ToString();
            
            OrderStatus os = Enum.Parse<OrderStatus>("Deliverd");

            Console.WriteLine(os);
            Console.WriteLine(txt);

        }
    }
}