using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_Part3_4;

internal class Car : Vehicle
{
    private int seats = 5;
    public int Seats
    {
        get {  return seats!; }
        set { seats = value; }


    }


    public override string StartEngine()
    {
        return "VR00000M";
    }

    public override string Stats()
    {
        return ($"This car is cool and have {seats} seats!");
    }










}











