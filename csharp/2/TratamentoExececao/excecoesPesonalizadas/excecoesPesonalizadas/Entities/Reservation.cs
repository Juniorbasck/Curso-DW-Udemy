using System.Runtime.InteropServices.JavaScript;
using excecoesPesonalizadas.Entities.Exceptions;

namespace excecoesPesonalizadas.Entities;

public class Reservation
{
    public int RoomNumber { get; set; }

    public DateTime CheckIn{ get; set; }
    
    public DateTime CheckOut{ get; set; }

    public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
    {
        if (checkIn <= checkIn)
        {
            throw new DomainException("Erro in reservation, date is wrong");
        }
        
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
        DateTime now = DateTime.Now;
        if (checkIn < now || checkOut < now)
        {
            throw new DomainException("can´t be update");
        }
        if (checkIn <= checkIn)
        {
            throw new DomainException("Erro in reservation, date is wrong");
        }
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