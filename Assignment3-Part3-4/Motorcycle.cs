using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_Part3_4;

internal class Motorcycle : Vehicle
{
    private bool hasSideCar = true;
    public bool HasSideCar
    {
        get { return hasSideCar!; }
        set { hasSideCar = value; }



    }



    public override string StartEngine()
    {
        return "EEEHMMM EHGMMMMMM";
    }

    public override string Stats()
    {
        return ($"This bike is cool and have a sidecar, it is {hasSideCar}!");
    }




















}


