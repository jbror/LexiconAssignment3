//Övning 3: Fordonshanteringssystem (Inkapsling, Arv & Polymorfism i C#)
using Assignment3;


Console.WriteLine("Hi hello!");
VehicleHandler handler = new VehicleHandler();
bool running = true;


while (running)
{
    Console.WriteLine("\n--- Vehicle Management ---");
    Console.WriteLine("1. Add new vehicle");
    Console.WriteLine("2. List all vehicles");
    Console.WriteLine("3. Update a vehicle");
    Console.WriteLine("4. Exit");
    Console.Write("Select an option: ");

    var input = Console.ReadLine();

    switch (input)
    {
        case "1":
            handler.AddVehicle();
            break;
        case "2":
            handler.ListVehicles();
            break;
        case "3":
            handler.Update();
            break;
        case "4":
            running = false;
            Console.WriteLine("Ok, bye bye");
            break;
        default:
            Console.WriteLine("Invalid option. Please choose 1–4.");
            break;
    }
}

