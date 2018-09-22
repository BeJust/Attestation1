using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    public class EconomCarriage : Carriage
    {
        public bool Heater { get; set; }
        public EconomCarriage(int number, int passNum, int LuggAmount, int ComfortLvl)
        {
            this.Number = number;
            this.PassNum = passNum;
            this.LuggAmount = LuggAmount;
            this.Comfort = ComfortLvl;
            this.Heater = true;
        }
    }
}
