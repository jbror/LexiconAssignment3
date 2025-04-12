// Part 3 and 4.
using Assignment3_Part3_4;

Console.WriteLine("Hi ho Hello");


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
}




//console.writeline(car.startengine());
//console.writeline(car.stats());

//console.writeline(truck.startengine());
//console.writeline(truck.stats());


//console.writeline(motorcycle.startengine());
//console.writeline(motorcycle.stats());


//console.writeline(electricscooter.startengine());
//console.writeline(electricscooter.stats());


