namespace projectInterface.Entities;

public class Vehicle
{
    public string Model { set; get; }

    public Vehicle(string model)
    {
        Model = model;
    }
}