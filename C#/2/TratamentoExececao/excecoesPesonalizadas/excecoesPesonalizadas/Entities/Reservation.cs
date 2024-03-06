using System.Runtime.InteropServices.JavaScript;

namespace excecoesPesonalizadas.Entities;

public class Reservation
{
    public int RoomNumber { get; set; }

    public DateTime CheckIn{ get; set; }
    
    public DateTime CheckOut{ get; set; }

    public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
    {
        RoomNumber = roomNumber;
        CheckIn = checkIn;
        CheckOut = checkOut;
    }

    public int durantion()
    {
        TimeSpan durantion = CheckOut.Subtract(CheckIn);
        return (int)durantion.TotalDays;
    }

    public void updateDates(DateTime checkIn, DateTime checkOut)
    {
        checkIn = checkIn;
        checkOut = checkOut;
    }

    public override string ToString()
    {
        return "Room"
               + RoomNumber
               + ", check-in: "
               + CheckIn.ToString("dd/MM/yyyy")
               + ", check-out: "
               + CheckOut.ToString("dd/MM/yyyy")
               + ", "
               + durantion()
               + " night ";
    }
}