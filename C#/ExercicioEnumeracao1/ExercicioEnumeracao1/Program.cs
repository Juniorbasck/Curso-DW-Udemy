using ExercicioEnumeracao1.Entities;
using ExercicioEnumeracao1.Entities.Enums;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace ExercicioEnumeracao1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter department's name: ");
            
            string depName = Console.ReadLine();

            Console.WriteLine("Enter worker data: ");


            Console.WriteLine("Name:");

            string name = Console.ReadLine();

            Console.Write("Level (Junior/MidLevel/Senior):");

            WorkLevel level = Enum.Parse<WorkLevel>(Console.ReadLine());

            Console.Write("Base salary:");

            Double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Departament dept = new Departament(depName);

            Work worker = new Work(name, level, baseSalary, dept);

            Console.Write("How many contracts to this worker?");

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter #{i} contract data:");

                DateTime date = DateTime.Parse(Console.ReadLine());


                Console.Write("Value per hour: ");

                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Duration (Hourss): ");

                int hour = int.Parse(Console.ReadLine());

                HourContract contract  = new HourContract(date, valuePerHour, hour);

                worker.Addcontract(contract);
            }

            Console.WriteLine();

            Console.Write("Enter month and year to calculate income (MM/YYYY): ");

            string mothAndYear = Console.ReadLine();

            int month = int.Parse(mothAndYear.Substring(0, 2));

            int year = int.Parse(mothAndYear.Substring(3, 4));

            //show datas

            Console.WriteLine("Name: " + worker.Name);

            Console.WriteLine("Departament: " + worker.Departament.Name);

            Console.WriteLine("Income for: " + mothAndYear + ": " + worker.Income(year, month));

        }
    }
}