using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca.Entities
{
    internal class Acount
    {
        public int Number { get; private set; }

        public string Holder { get; private set; }

        public double Balance { get; protected set; }

        public Acount() 
        {
        }

        public Acount(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public virtual void Withdraw(double amount) 
        {
            Balance -= amount + 5.0;
        }

        public void deposito(double amount)
        {
            Balance += amount;
        }
    }
}
