//Övning 3: Fordonshanteringssystem (Inkapsling, Arv & Polymorfism i C#)
using Assignment3;


Console.WriteLine("Hi hello!");
VehicleHandler handler = new VehicleHandler();
List<SystemError> errors = new List<SystemError>();
errors.Add(new EngineFailureError());
errors.Add(new BrakeFailureError());
errors.Add(new TransmissionError());
bool running = true;

void DisplaySystemErrors()
{
    foreach (var i in errors)
    {
        Console.WriteLine(i.ErrorMessage());
    }
}

while (running)
{
    Console.WriteLine("\n--- Vehicle Management ---");
    Console.WriteLine("1. Add new vehicle");
    Console.WriteLine("2. List all vehicles");
    Console.WriteLine("3. Update a vehicle");
    Console.WriteLine("4. Exit");
    Console.WriteLine("5. Display current system errors");

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
        case "5":
            Console.WriteLine("Ok, enjoy the errors!");
            DisplaySystemErrors();
            break;
        default:
            Console.WriteLine("Invalid option. Please choose 1–5.");
            break;
    }
    
}

