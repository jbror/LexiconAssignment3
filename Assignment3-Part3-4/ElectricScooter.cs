using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_Part3_4;

internal class ElectricScooter : Vehicle
{

    private int batteryRange = 1500;
    public int BatteryRange
    {
        get { return batteryRange!; }
        set { batteryRange = value; }



    }



    public override string StartEngine()
    {
        return "bssssssss";
    }

    public override string Stats()
    {
        return ($"This scooter is cool and have {batteryRange} batteryrange!");
    }




















}









