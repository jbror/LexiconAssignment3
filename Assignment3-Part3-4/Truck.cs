using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_Part3_4;

internal class Truck : Vehicle, ICleanable
{
    private double cargoCapacity = 1500;
    public double CargoCapacity
    {
        get { return cargoCapacity!; }
        set { cargoCapacity = value; }



    }



    public override string StartEngine()
    {
        return "BRUUUUUUM";
    }

    public override string Stats()
    {
        return ($"This truck is cool and have {cargoCapacity} cargospace!");
    }



    public void Clean()
    {
        Console.WriteLine("My truck just got really shiny. Its cleaned!!");
    }

















}





