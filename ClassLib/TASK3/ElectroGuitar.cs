using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib.TASK3
{
    public class ElectroGuitar : Guitar
    {
        public string Color { get; set; }
        public int PossibleLoudness { get; set; }
     
        public ElectroGuitar(string name, int price, string color, int possibleLoudness)
        {
            this.Name = name;
            this.Price = price;
            this.Color = color;
            this.PossibleLoudness = possibleLoudness;
            this.TypeOfTheGuitar = "Электрогитара";
        }

        public override string DefineTypeOfInstrument()
        {
            return TypeOfTheGuitar;
        }
        
        public string IncreaseVolume()
        {
            return "Громкость увеличена";
        }
        public string DecreaseVolume()
        {
            return "Громкость уменьшена";
        }

    }
}
