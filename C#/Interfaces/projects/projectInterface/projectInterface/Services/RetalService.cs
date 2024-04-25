using System.Runtime;
using projectInterface.Entities;

namespace projectInterface.Services;

public class RetalService
{
    public double PricePerHour { get; private set; }
    public double PricePerDay { get; private set; }

    public RetalService(double pricePerHour, double pricePerDay)
    {
        PricePerHour = pricePerHour;
        PricePerDay = pricePerDay;
    }

    public void ProcessInvoice(CarRental carRental)
    {
        
    }
}