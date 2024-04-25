using System.Runtime.InteropServices.JavaScript;


namespace projectInterface.Entities;

public class CarRental
{
    public DateTime Start { get; set; }
    public DateTime Fish { get; set; }
    public Vehicle Vehicle { get; set; }
    public Invoice Invoice { get; set; }


    public CarRental(DateTime start, DateTime fish, Vehicle vehicle)
    {
        Start = start;
        Fish = fish;
        Vehicle = vehicle;
        Invoice = null;
    }
}