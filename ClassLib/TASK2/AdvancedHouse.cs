using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    public class AdvancedHouse : House
    {
        

        public bool Location { get; set; } // true - центр, false - окраина

        public AdvancedHouse(int houseNum, int flatsNum, int yearOfBuild, bool location) : base(houseNum, flatsNum, yearOfBuild)
        {
            this.HouseNumber = houseNum;
            this.FlatsNumber = flatsNum;
            this.YearOfBuilding = yearOfBuild;
            this.Location = location;
        }

        public override double CalculateQuality()
        {
            if (Location)
            {
                return 2 * base.CalculateQuality();
            }
            else
            {
                return base.CalculateQuality() / 2;
            }
        }
        public override string OutputInfo()
        {
            string location = (this.Location) ? "центр" : "окраина";
            return  String.Format("Номер дома: {0}; Кол-во квартир: {1}; Год постройки: {2}; Местонахождение: {3}; Качество: {4};", this.HouseNumber, this.FlatsNumber, this.YearOfBuilding, location, this.GetQ());
        }
    }
}
