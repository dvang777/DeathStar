using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeathStar;

namespace TopSecretPlans
{
    public class HydrogenGenerator : Reactor, IActivate
    {
        public int HydrogenChargeRate = 6;
        public HydrogenGenerator(int PowerRate) : base(PowerRate)
        {
            
        }

        public void activate()
        {
            ChargeHydrogen();
        }

        public int ChargeHydrogen()
        {
            return PowerRate * HydrogenChargeRate;
        }

        public void refresh()
        {
            Exhaust();
        }
    }
}
