using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSecretPlans
{
    public class Thermalexhaustport : Exhaust, IChangeTemperature
    {
        public int Temperature;
        

        public Radiation ExpendExhaust(ReactorCore core)
        {
            core.CoolDown();
            this.HeatUp();
            return new Radiation();
        }
        public void HeatUp()
        {
             this.Temperature++;
        }
        
        public void CoolDown()
        {
             this.Temperature--;
        }
        public void ClosePort()
        {
            isOpen = false;
            Console.WriteLine("You are now protected by lasers shooting into this thermal exhaust port and blowing up your Death Star");
            
        }
    }
}
