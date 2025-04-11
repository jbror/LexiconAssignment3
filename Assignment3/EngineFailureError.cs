using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3;

class EngineFailureError : SystemError

{
    public override void ErrorMessage()
    {
        Console.WriteLine("Engine failure!"); 
    }
}
