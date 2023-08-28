using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace resolvendoOPP
{
    internal class Triangulo
    {
        public double A;  

        public double B;

        public double C;

        public double Area()
        {
            double p = (A + B + C) / 2.0;
            double raiz = Math.Sqrt(p * (p * A) * (p - B) * (p - C));

            return raiz;
        }

    }
}
