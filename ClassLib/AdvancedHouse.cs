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
            double quality;
            if (Location)
            {
                quality = 2 * ((FlatsNumber) + 2 * (2018 - YearOfBuilding));
                this.Quality = quality;
                return quality;
            }
            else
            {
                quality = ((FlatsNumber) + 2 * (2018 - YearOfBuilding))/2;
                this.Quality = quality;
                return quality;
            }
        }
        public override string OutputInfo()
        {
            string location = (this.Location) ? "центр" : "окраина";
            return  String.Format("Номер дома: {0}; Кол-во квартир: {1}; Год постройки: {2}; Местонахождение: {3}; Качество: {4};", this.HouseNumber, this.FlatsNumber, this.YearOfBuilding, location, this.Quality);
        }
    }
}
