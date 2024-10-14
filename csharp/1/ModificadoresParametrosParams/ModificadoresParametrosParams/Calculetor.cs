using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModificadoresParametrosParams
{
    internal class Calculetor
    {

        public static int Sum(params int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;


           
        }

        public static void Triple(int oringin, out int result)
        {
            result = oringin * 3;
        }
    }
}
