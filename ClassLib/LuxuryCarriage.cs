using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    public class LuxuryCarriage : Carriage
    {
        public bool FreeFood { get; set; }
        public LuxuryCarriage(int number, int passNum, int LuggAmount, int ComfortLvl)
        {
            this.Number = number;
            this.PassNum = passNum;
            this.LuggAmount = LuggAmount;
            this.Comfort = ComfortLvl;
            this.FreeFood = true;
        }
    }
}
