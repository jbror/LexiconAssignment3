using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_Part3_4;

internal class Truck : Vehicle
{
    private double cargoCapacity = 1500;
    public double CargoCapacity
    {
        get { return cargoCapacity; }
        set { cargoCapacity = value; }



    }



    public override string StartEngine()
    {
        return "VR00000M";
    }

    public override string Stats()
    {
        return ($"This car is cool and have {cargoCapacity} cargospace!");
    }




















}





