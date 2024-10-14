using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ExerFixacaa
{
    internal class ContaBancaria
    {

        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
        }

        public ContaBancaria(int numero, string titular, double depositoInicial) : this(numero, titular)
        {
            Deposito(depositoInicial);
        }

        public void Deposito(double valor)
        {
            Saldo += valor;
        }

        public void Saque(double valor)
        {
            Saldo -= valor;
            Saldo -= 5.0;
        }


        public override string ToString()
        {
            return "Conta "
                + Numero
            +", Titular: "
            + Titular
            + ", saldo: $ "
            + Saldo.ToString("F2", CultureInfo.InvariantCulture);
               
        }
    }
}
