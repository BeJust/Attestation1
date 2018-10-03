using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib.TASK3
{
    public abstract class Guitar : IMusicInstrument
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public string TypeOfTheGuitar { get; set; }

        public string OutputName()
        {
            return Name;
        }
        public  string TuneTheGuitar()
        {
            return "Гитара настроена!";
        }
        
        public abstract string DefineTypeOfInstrument();

       
        
    }
}
