// Part 3 and 4.
using Assignment3_Part3_4;

Console.WriteLine("Hi ho Hello");
Console.WriteLine();



Car car = new Car();
Truck truck = new Truck();
Motorcycle motorcycle = new Motorcycle();
ElectricScooter electricScooter = new ElectricScooter();

List<Vehicle> vehicles = new List<Vehicle>();
vehicles.Add(car);
vehicles.Add(truck);
vehicles.Add(motorcycle);
vehicles.Add(electricScooter);

foreach (var i in vehicles)
{
    Console.WriteLine(i.Stats());
    Console.WriteLine();

    if (i is ICleanable cleanable)
    {
        cleanable.Clean();
    }
}




