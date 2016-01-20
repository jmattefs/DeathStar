using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSecretPlans
{
    public class HyperDrive : IActivate
    {
		public string destination;
        public int fuelCellLevel;
        public int gravityLevel;
        public bool hyperDriveExecution;
        public HyperDrive(string Destination, int FuelCellLevel, int GravityLevel, bool HyperDriveExecution)
        {
            destination = Destination;
            fuelCellLevel = FuelCellLevel;
            gravityLevel = GravityLevel;
            hyperDriveExecution = HyperDriveExecution;
        }

        public void activate()
        {
            UseHyperDrive();
           
        }

        public bool IsHyperDriveExecuted()
        {
            if(hyperDriveExecution==true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void refresh()
        {
            IsHyperDriveExecuted();
        }

        public void UseHyperDrive()
        {
            if(fuelCellLevel>0)
            {
                this.hyperDriveExecution = true;
                this.fuelCellLevel--;
                this.gravityLevel = 0;
                Console.WriteLine("You have used the hyperdrive, you are now in " + destination);
            }
           else
            {
                this.hyperDriveExecution = false;
                Console.WriteLine("your fuel Cell Level is " + this.fuelCellLevel);
            }
        }
    }


}
