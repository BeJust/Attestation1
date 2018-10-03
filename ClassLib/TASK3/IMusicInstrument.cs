using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib.TASK3
{
    public interface IMusicInstrument
    {
        string Name { get; set; }

        string OutputName();
        string DefineTypeOfInstrument();
    }
}
