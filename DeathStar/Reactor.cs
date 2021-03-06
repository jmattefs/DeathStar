﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSecretPlans
{
    public class Reactor : IActivate
    {
        public int PowerRate
		{
			private set
			{
				PowerRate = value;
			}
			get
			{
				return PowerRate;
			}
		}
        private int InitialPowerPercent = 0;
        public int MaxPowerPercent = 100;

        public Reactor(int PowerRate)
        {
            this.PowerRate = PowerRate;
        }
        public int GeneratePower()
        {
            if(InitialPowerPercent <= MaxPowerPercent)
            {
                PowerRate++;
            }
            return PowerRate;
        }

        public void activate()
        {
            GeneratePower();
        }

        public void refresh()
        {
            Console.WriteLine("Power rate is: " + PowerRate);
        }
    }
}
