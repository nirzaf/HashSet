using static System.Console;


HashSet<Vehicle> vehicles = new()
{
    new("Car"),
    new("Bike"),
    new("Bike"),
    new("Bike"),
    new("Van")
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