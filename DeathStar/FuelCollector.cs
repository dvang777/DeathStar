using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeathStar;

namespace TopSecretPlans
{
    public class FuelCollector : IActivate
    {
        public int tankSizeInGallons;
        public bool isTankFull;

        public FuelCollector(int TankSizeInGallons)
        {
            tankSizeInGallons = TankSizeInGallons;
        }
        public void fuelTankStatus()
        {
            if (isTankFull == true) 
            {
                Console.WriteLine("Fuel Tank is full, ready to go.");
            }
            else
            {
                Console.WriteLine("Fuel Tank needs a refill.");
            }
        }

        public void activate()
        {
            fuelTankStatus();
        }

        public void refresh()
        {

        }
    }
}