using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioEnumeracao1.Entities
{
    internal class HourContract
    {

        public DateTime Date { get; set; }

        public double ValuePerHour { get; set; }

        public int Hour {  get; set; }

        public HourContract() 
        {
        
        }

        public HourContract(DateTime date, double valuePerHour, int hour)
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hour = hour;
        }

        public Double TotalValue()
        {
            return Hour * ValuePerHour;
        }

    }
}
