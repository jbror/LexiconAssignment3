using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3;

internal class VehicleHandler
{
    private List<Vehicle> vehicles = new List<Vehicle>();


    public void AddVehicle()
    {
        try
        {
            Console.Write("Enter brand: ");
            var brand = GetStringFromUser();

            Console.Write("Enter model: ");
            var model = GetStringFromUser();


            Console.Write("Enter year: ");
            int year = GetIntFromUser();


            Console.Write("Enter weight: ");
            double weight = GetDoubleFromUser();

            Vehicle newVehicle = new Vehicle(brand, model, year, weight);
            vehicles.Add(newVehicle);
            Console.WriteLine("Vehicle added, nice job!");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid number format! Please enter correct values.");


        }
    }

    // 2. Lista fordon
    public void ListVehicles()
    {
        if (vehicles.Count == 0)
        {
            Console.WriteLine("No vehicles available.");
            return;
        }

        for (int i = 0; i < vehicles.Count; i++)
        {
            var v = vehicles[i];
            Console.WriteLine($"{i + 1}. Brand: {v.Brand}, Model: {v.Model}, Year: {v.Year}, Weight: {v.Weight} kg");
        }
    }

    // 3. Uppdatera fordon
    public void Update()
    {
        int userInputNumber;
        int vehicleIndex;

        while (true)
        {
            ListVehicles();

            Console.WriteLine("Enter the number of the vehicle you want to update:");

            if (int.TryParse(Console.ReadLine(), out userInputNumber))
            {
                vehicleIndex = userInputNumber - 1;

                if (vehicleIndex >= 0 && vehicleIndex < vehicles.Count)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input or invalid range.");
                }
            }
            else
            {
                Console.WriteLine("Invalid number! Try again.");
            }
        }

        Vehicle vehicleToUpdate = vehicles[vehicleIndex];

        Console.WriteLine("What would you like to update?");
        Console.WriteLine("1. Brand");
        Console.WriteLine("2. Model");
        Console.WriteLine("3. Year");
        Console.WriteLine("4. Weight");


        Console.Write("Enter choice: ");
        var choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                Console.Write("Enter new Brand (2–20 characters): ");

                var newBrand = GetStringFromUser();
                try
                {
                    vehicleToUpdate.Brand = newBrand;
                    Console.WriteLine("Brand updated successfully!");
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
                break;

            case "2":
                Console.Write("Enter new Model (2–20 characters): ");
                var newModel = GetStringFromUser();
                try
                {
                    vehicleToUpdate.Model = newModel;
                    Console.WriteLine("Model updated successfully!");
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
                break;

            case "3":
                Console.Write("Enter year: ");
                int newYear = GetIntFromUser();
                
                    try
                    {
                        vehicleToUpdate.Year = newYear;
                        Console.WriteLine("Year updated successfully!");
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine($"Error: {ex.Message}");
                    }
         
                break;

            case "4":
                Console.Write("Enter new weight (positive number): ");
                double newWeight = GetDoubleFromUser();
                
                    try
                    {
                        vehicleToUpdate.Weight = newWeight;
                        Console.WriteLine("Weight updated successfully!");
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine($"Error: {ex.Message}");
                    }

                break;

            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
    }

    public string GetStringFromUser()
    {
        //Console.WriteLine("Please enter a string:");
        string value;

        while (true)
        {
            var userInput = Console.ReadLine();
            if (userInput == null)
            {
                Console.WriteLine("You must enter a value");
            }
            else
            {
                value = userInput;
                break;
            }
        }


        return value;



    }

    public int GetIntFromUser()
    {
        int value;

        while (true)
        {
            Console.Write("Enter year: ");
            var input = Console.ReadLine();

            if (int.TryParse(input, out value))
            {
                return value;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }
    }



    public double GetDoubleFromUser()
    {
        double value;

        while (true)
        {
            Console.Write("Enter weight, decimals is accepted: ");
            var input = Console.ReadLine();

            if (double.TryParse(input, out value))
            {
                return value;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
    }





}

