using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.JavaScript;
using excecoesPesonalizadas.Entities;
using excecoesPesonalizadas.Entities.Exceptions;

public class Program
{
    public static void Main()
    {
        try
        {
            Console.Write("Room number: ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Check-in data (dd/MM/YYY): ");
            DateTime checkin = DateTime.Parse(Console.ReadLine());

            Console.Write("Checkout date (dd/MM/YYYY): ");
            DateTime checkout = DateTime.Parse(Console.ReadLine());

            Reservation reservation = new Reservation(number, checkin, checkout);
            Console.WriteLine("Reservartion: " + reservation);

            Console.WriteLine();
            Console.WriteLine("Enter with the datas to update the reservation");
            Console.Write("Check-in data (dd/MM/YYY): ");
            checkin = DateTime.Parse(Console.ReadLine());

            Console.Write("Checkout date (dd/MM/YYYY): ");
            checkout = DateTime.Parse(Console.ReadLine());
            reservation.updateDates(checkin, checkout);

            Console.WriteLine("Reservation:  " + reservation);
        }
        catch(DomainException e)
        {
            Console.WriteLine("Error in resevation: " + e.Message);
        }
    }
}