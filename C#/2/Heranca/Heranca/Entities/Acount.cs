﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca.Entities
{
    internal class Acount
    {
        public int Number { get; set; }

        public string Holder { get; set; }

        public double Balance { get; set; }

        public Acount() 
        {
        }

        public Acount(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public void Withdraw(double amount) 
        {
            Balance -= amount;
        }

        public void deposito(double amount)
        {
            Balance += amount;
        }
    }
}