using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3;
class BrakeFailureError : SystemError

{
    public override string ErrorMessage()
    {
        return "Brake failure!";
    }
}