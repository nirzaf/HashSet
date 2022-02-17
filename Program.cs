using System.Collections;
using static System.Console;


HashSet<Vehicle> vehicles = new HashSet<Vehicle>
{
    new Vehicle("Car"),
    new Vehicle("Bike"),
    new Vehicle("Bike"),
    new Vehicle("Bike"),
    new Vehicle("Van")
};


WriteLine(vehicles.Count);


HashSet<string> stringHash = new HashSet<string>();

IDictionary<string, Vehicle> veh = new Dictionary<string, Vehicle>();

stringHash.Add("Fazrin");
stringHash.Add("Fazrin");
stringHash.Add("Razmy");
stringHash.Add("Fazrin");


WriteLine(stringHash.Count);

ReadKey();


public class Vehicle
{
    private readonly string _name;

    public Vehicle(string name)
    {
        _name = name;
    }
}