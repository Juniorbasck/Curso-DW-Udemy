using ExercicioEnumeracao1.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioEnumeracao1.Entities
{
    internal class Work
    {
        public string Name { get; set; }

        public WorkLevel Level { get; set; }

        public double BaseSalary { get; set; }

        public Departament Departament { get; set; }

        public List<HourContract> Contracts { get; set; } = new List<HourContract>();

        public Work(string name, WorkLevel level, double baseSalary, Departament departament) 
        {
            Name = name;

            Level = level; 

            BaseSalary = baseSalary;

            Departament = departament;
        }

        public void Addcontract(HourContract contract)
        {
            Contracts.Add(contract);
        }

        public void Removecontract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public double Income(int year, int month)
        {
            var soma = BaseSalary;
            
            foreach (HourContract contract in Contracts)
            {
                if(contract.Date.Year == year && contract.Date.Month == month)
                {
                    soma += contract.TotalValue();
                }
            }

            return soma;
        }
    }
}
