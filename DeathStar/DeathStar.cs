using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopSecretPlans;

namespace DeathStar
{
    public class DeathStar
    {
        Mainexhaustport mainExhaustPort;
        public Thermalexhaustport ThermalExhaustPort;
        TractorBeam tractorBeam;
        ///TractorBeamGenerator tractorBeamGenerator;
        ///EmergencyRadiationDischarge emergencyRadiationDischarge;
        MainPowerGenerator mainPowerGenerator;
        HyperMatterReactor hyperMatterReactor;
        IonDriveReactor ionDriveReactor;
        OverBridge overBridge;
        public SuperLaser superLaser;
        MagneticShielding magneticShielding;
        public HyperDrive hyperDrive;
        PowerCell powerCell;
        CentralComputerCore centralComputerCore;
        HeatExchanger heatExchanger;
        CoolingSystem coolingSystem;
        public Refinery refinery;
        FuelCollector fuelCollector;
        ExteriorQuadaniumsteelouterhull exteriorQuadaniumSteelOuterHull;
        
        public DeathStar()
        {
            hyperDrive = new HyperDrive("Hoth", 100, 100, true);
            superLaser = new SuperLaser(100, 100, 100);
            ThermalExhaustPort = new Thermalexhaustport();

        }
    }
}
