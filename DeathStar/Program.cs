﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopSecretPlans;


namespace DeathStar
{
    public class Program
    {
        static void Main(string[] args)
        {
            ExteriorQuadaniumsteelouterhull exteriorQuandaniumsteelouterhull = new ExteriorQuadaniumsteelouterhull(100, 100, 100);
            Console.WriteLine("Outer Shell Hardness is {0}, Health is {1}, Nanites are at {2}", exteriorQuandaniumsteelouterhull.Hardness, exteriorQuandaniumsteelouterhull.Health, exteriorQuandaniumsteelouterhull.Nanites);
            exteriorQuandaniumsteelouterhull.TakeDamage();
            exteriorQuandaniumsteelouterhull.NaniteRepair();

            Reactor reactor = new Reactor(100);
            Console.WriteLine("Power is {0} %", reactor);
            reactor.GeneratePower();

            ReactorCore reactorCore = new ReactorCore(50, 100, 50, 100, 100, 100, 100);
            Console.WriteLine("Fuel rod level {1}, control rod level {3}, water reactor level {4}, uranium level {5}, boron level {6}", reactorCore.fuelRodLevel, reactorCore.controlRodLevel, reactorCore.waterReactorLevel, reactorCore.uraniumAmount, reactorCore.boronAmount);
            //ReactorCore.EvasionCheck(50, 100, 50, 100, 100, 100, 100, 100);


        }
    }
}
