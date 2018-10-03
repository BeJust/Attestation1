using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    public class House
    {
        public int HouseNumber { get; set; }
        public int FlatsNumber { get; set; }
        public int YearOfBuilding { get; set; }
       


        public House(int houseNum, int flatsNum, int yearOfBuild)
        {
            this.HouseNumber = houseNum;
            this.FlatsNumber = flatsNum;
            this.YearOfBuilding = yearOfBuild;
        }

        public double GetQ()
        {
            return CalculateQuality();
        }
        public virtual double CalculateQuality()
        {
            double quality = ((FlatsNumber) + 2 * (2018 - YearOfBuilding));
            return quality;
        }

        public virtual string OutputInfo()
        {
            string result = String.Format("Номер дома: {0}; Кол-во квартир: {1}; Год постройки: {2}; Качество: {3};", this.HouseNumber, this.FlatsNumber, this.YearOfBuilding, GetQ());
            return result;
        }
    }
}
