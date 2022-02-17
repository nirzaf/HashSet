using static System.Console;


HashSet<Vehicle> vehicles = new()
{
    new Vehicle("Car"),
    new Vehicle("Bike"),
    new Vehicle("Bike"),
    new Vehicle("Bike"),
    new Vehicle("Van")
};


WriteLine(vehicles.Count);


HashSet<string> stringHash = new();

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