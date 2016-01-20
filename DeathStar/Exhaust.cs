using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeathStar;

namespace TopSecretPlans
{
    public class Exhaust : IActivate
    {
        private readonly int Diameter;
        private readonly int Length;
        private readonly int numberOfFans;
        
        public Exhaust()
        {
            HydrogenGenerator hydrogenGenerator = new HydrogenGenerator(100);
            HydrogenGenerator(100).activate();
        }
        public Exhaust(int diameter, int length, int numberOfFans)
        {
            this.Diameter = diameter;
            this.Length = length;
            this.numberOfFans = numberOfFans;
        }
        public bool isOpen;

        public virtual Radiation ExpendExhaust()
        {
            return null;
        }

        public void activate()
        {
            throw new NotImplementedException();
        }

        public void refresh()
        {
            throw new NotImplementedException();
        }
    }
}
