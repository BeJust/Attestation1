using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    public class Carriage : IComparable
    {
        
        public int Number { get; set; }
        public int Comfort { get; set; }
        public int LuggAmount { get; set; }
        public int PassNum { get; set; }

        
        
        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            Carriage otherCarriage = obj as Carriage;
            if (otherCarriage != null)
            {
                return this.Comfort.CompareTo(otherCarriage.Comfort);
            }
            else
            {
                throw new ArgumentException("Обьект не является вагоном");
            }
        }
    }
}
