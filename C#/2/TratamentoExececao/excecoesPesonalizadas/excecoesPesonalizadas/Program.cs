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
        }
    }
}