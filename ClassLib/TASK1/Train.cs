using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    public class Train
    {
        public string Name { get; set; }
        public List<Carriage> CarriagesConnected{ get; set; }
        
        public Train(string name)
        {
            this.Name = name;
            this.CarriagesConnected = new List<Carriage>();
        }
        public void ComfortSort()
        {
            CarriagesConnected.Sort();
        }

        public int GetPassNumber()
        {
            return CarriagesConnected.Sum(x=>x.PassNum);
        }

        public double GetLuggAmount()
        {
            return CarriagesConnected.Sum(x => x.LuggAmount);
        }

        public List<Carriage> FindAppropiateCarriages(int minNumPass, int maxNumPass)
        {
            return CarriagesConnected.Where(x => (x.PassNum > minNumPass && x.PassNum < maxNumPass)).ToList();
        }
        public void ConnectCarriage(Carriage carriage)
        {
            CarriagesConnected.Add(carriage);
        }
        public void DisconnectCarriage(int  number)
        {
            for(int i = 0; i < CarriagesConnected.Count; i++)
            {
                if(CarriagesConnected[i].Number == number)
                {
                    CarriagesConnected.Remove(CarriagesConnected[i]);
                    break;
                }             
            }            
        }
    }
}
