using System;
using System.Collections.Generic;

namespace gary_garage
{
    class Program
    {
        static void Main(string[] args)
        {
            Ram ram = new Ram();
            ram.MainColor = "blue";
            ram.MaximumOccupancy = 5;

            Cessna mx410 = new Cessna();
            mx410.MainColor = "white";
            mx410.MaximumOccupancy = 12;

            Seadoo spark = new Seadoo();
            spark.MainColor = "grey";
            spark.MaximumOccupancy = 4;

            Tesla modelS = new Tesla();
            modelS.MainColor = "black";
            modelS.MaximumOccupancy = 4;

            Zero fxs = new Zero();
            fxs.MainColor = "red";
            fxs.MaximumOccupancy = 4;

            ram.Drive();
            mx410.Drive();
            spark.Drive();
            modelS.Drive();
            fxs.Drive();
            Console.WriteLine("");
            ram.Turn();
            mx410.Turn();
            spark.Turn();
            modelS.Turn();
            fxs.Turn();
            Console.WriteLine("");
            ram.Stop();
            mx410.Stop();
            spark.Stop();
            modelS.Stop();
            fxs.Stop();

            // this is a list of electricVehicles
            List<IElectricVehicle> electricVehicles = new List<IElectricVehicle>()
            {
                fxs,
                modelS
            };
            // This say for each electric vehicle show the current charged precentage 

            Console.WriteLine("Electric Vehicles");
            foreach (IElectricVehicle ev in electricVehicles)
            {
                Console.WriteLine($"Your battery is at {ev.CurrentChargePercentage} precent.");
            }
            // This say for each electrice vehicle charge battery to 100 precent
            foreach (IElectricVehicle ev in electricVehicles)
            {
                // This should charge the vehicle to 100%
                ev.ChargeBattery();
            }

            // This say for each electric vehicle show the current charged precentage  which should be 100 precent now
            foreach (IElectricVehicle ev in electricVehicles)
            {
                Console.WriteLine($"Your battery is at {ev.CurrentChargePercentage} precent now!");
            }

            /***********************************************/

            List<IGasVehicle> gasVehicles = new List<IGasVehicle>()
            {
                ram,
                mx410,
                spark,

            };
            // This say for each gas vehicle show the current tank precentage 
            Console.WriteLine("Gas Vehicles");
            foreach (IGasVehicle gv in gasVehicles)
            {
                Console.WriteLine($"Your tank is at {gv.CurrentTankPercentage} precent.");
            }
            // This say for each gas vehicle fill the tank to 100 precent
            foreach (IGasVehicle gv in gasVehicles)
            {
                // This should completely refuel the gas tank
                gv.RefuelTank();
            }
            // This say for each gas vehicle show the current tank precentage which should be 100 precent now
            foreach (IGasVehicle gv in gasVehicles)
            {
                Console.WriteLine($"Your tank is at {gv.CurrentTankPercentage} precent now!");
            }
        }
    }
}