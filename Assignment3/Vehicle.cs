using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3;

internal class Vehicle
{
    private string? brand;
    private string? model;
    private int year;
    private double weight;

    public string Brand
    {
        get => brand!;
        set
        {
            if (value.Length >= 2 && value.Length <= 20)
            {
                brand = value;
            }
            else
            {
                throw new ArgumentException("Name of Brand can only contain 2 - 20 letters");
            }
        }
    }
    public string Model
    {
        get => model!;
        set
        {
            if (value.Length >= 2 && value.Length <= 20)
            {
                model = value;
            }
            else
            {
                throw new ArgumentException("Name of Model can only contain 2 - 20 letters");
            }
        }
    }
    public int Year
    {
        get => year!;
        set
        {
            
            int currentYear = DateTime.Now.Year;
            if (value >= 1886 && value <= currentYear)
            {
                year = value;
            }
            else
            {
                throw new ArgumentException("To old car!");
            }
        }
    }


    public double Weight
    {
        get => weight;
        set
        {
            if (value > 0)
                weight = value;
            else
                throw new ArgumentException("The car must weight something!");
        }
    }







    public Vehicle(string brandName, string modelName, int yearsOld, double vehicleWeight)
    {
        Brand = brandName;
        Model = modelName;
        Year = yearsOld;
        Weight = vehicleWeight;
    }
}



