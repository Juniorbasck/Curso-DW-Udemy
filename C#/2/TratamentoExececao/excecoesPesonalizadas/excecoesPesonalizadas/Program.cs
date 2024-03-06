using System;
using System.Runtime.InteropServices.JavaScript;
using excecoesPesonalizadas.Entities;

public class Program
{
    public static void Main()
    {
        Console.Write("Room number: ");
        int number = int.Parse(Console.ReadLine());

        Console.Write("Check-in data (dd/MM/YYY): ");
        DateTime checkin = DateTime.Parse(Console.ReadLine());
        
        Console.Write("Checkout date (dd/MM/YYYY): ");
        DateTime checkout = DateTime.Parse(Console.ReadLine());

        if (checkout <= checkin)
        {
            Console.WriteLine("Erro in reservation, date is wrong");
        }
        else
        {
            Reservation reservation = new Reservation(number, checkin, checkout);
            Console.WriteLine("Reservartion: " + reservation);
            
            Console.WriteLine();
            Console.WriteLine("Enter with the datas to update the reservation");
            Console.Write("Check-in data (dd/MM/YYY): ");
            checkin = DateTime.Parse(Console.ReadLine());
        
            Console.Write("Checkout date (dd/MM/YYYY): ");
            checkout = DateTime.Parse(Console.ReadLine());

            DateTime now = DateTime.Now;
            if (checkin < now || checkout < now)
            {
                Console.WriteLine("can´t be update");
            }
            else if (checkout <= checkin)
            {
                Console.WriteLine("Erro in reservation, date is wrong");
            }
            else
            {
                reservation.updateDates(checkin, checkout);
                
                Console.WriteLine("Reservation:  " + reservation);
            }
        }
    }
}