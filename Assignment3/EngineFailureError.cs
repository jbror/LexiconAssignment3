using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3;

class EngineFailureError : SystemError

{
    public override string ErrorMessage()
    {
        return "Engine failure!";
    }
}
