﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeathStar;

namespace TopSecretPlans
{
    public class CoolingSystem : IChangeTemperature, IActivate
    {
        int OverAllTemperature;

        public void activate()
        {
            CoolDown();
        }

        public void Cool(IChangeTemperature part)
        {
            part.CoolDown();
            HeatUp();
        }

        public void CoolDown()
        {
            OverAllTemperature--;
        }

        public void HeatUp()
        {
            OverAllTemperature++;
        }

        public void refresh()
        {
            HeatUp();
        }
    }
}
