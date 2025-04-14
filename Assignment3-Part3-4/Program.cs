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




//Frågor(besvaras som kommentarer i koden):
//• F: Vad händer om du försöker lägga till en Car i en lista av Motorcycle?  :  Eftersom Car inte är av typen Motorcycle så kan jag inte lägga till car.
//• F: Vilken typ bör en lista vara för att rymma alla fordonstyper? Vehicle
//• F: Kommer du åt metoden Clean() från en lista med typen List<Vehicle>? Ja och nej? Om en underklass innehåller metoden kan jag komma åt den
//• F: Vad är fördelarna med att använda ett interface här istället för arv? Interface kan delas och implementeras smidigare när inte annan funktioalitet ska ärvas.