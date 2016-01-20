using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DeathStar
{
    public class Program
    {
        static void Main(string[] args)
        {
            DeathStar deathStar = new DeathStar();
            deathStar.hyperDrive.UseHyperDrive();
            deathStar.superLaser.FireLaser();
            deathStar.superLaser.Recharge();
            deathStar.superLaser.TripleShot();
            deathStar.superLaser.Recharge();
            deathStar.ThermalExhaustPort.ClosePort();
            deathStar.ThermalExhaustPort.OpenPort();
        }
    }
}
