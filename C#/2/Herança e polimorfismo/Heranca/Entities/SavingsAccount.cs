using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca.Entities
{
    internal class SavingsAccount : Acount
    {

        public double InteresRate { get; set; }

        public SavingsAccount()
        {
        }

        public SavingsAccount(int number, string holder, double balance, double interesRate)
            : base(number, holder, balance)
        {
            InteresRate = interesRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InteresRate;
        }

        public override void Withdraw(double  amount)
        {
            Balance -= amount;
        }
    }
}
