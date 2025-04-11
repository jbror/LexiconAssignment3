using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3;

class TransmissionError : SystemError

{
    public override string ErrorMessage()
    {
        return "Transmission error!";
    }
}   