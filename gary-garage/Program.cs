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

            // ram.Drive();
            // mx410.Drive();
            // spark.Drive();
            // modelS.Drive();
            // fxs.Drive();
            // Console.WriteLine("");
            // ram.Turn();
            // mx410.Turn();
            // spark.Turn();
            // modelS.Turn();
            // fxs.Turn();
            // Console.WriteLine("");
            // ram.Stop();
            // mx410.Stop();
            // spark.Stop();
            // modelS.Stop();
            // fxs.Stop();

            // static void Drive(Vehicle aVehicle)
            // {
            //     aVehicle.Drive();
            // }

            // static void Turn(Vehicle aVehicle)
            // {
            //     aVehicle.Turn();
            // }
            // static void Stop(Vehicle aVehicle)
            // {
            //     aVehicle.Stop();
            // }
            // List<IElectricVehicle> electricVehicles = new List<IElectricVehicle>()
            // {
            //     fxs,
            //     modelS
            // };

            Console.WriteLine("Electric Vehicles");
            foreach (IElectricVehicle ev in electricVehicles)
            {
                Console.WriteLine($"{ev.CurrentChargePercentage}");
            }

            foreach ( ?? ? ev in electricVehicles)
            {
                // This should charge the vehicle to 100%
                ev.ChargeBattery();
            }

            foreach ( ?? ? ev in electricVehicles)
            {
                Console.WriteLine($"{ev.CurrentChargePercentage}");
            }

            /***********************************************/

            List<IGasVehicle> gasVehicles = new List<IGasVehicle>()
            {
                ram,
                mx410,
                spark,

            };

            Console.WriteLine("Gas Vehicles");
            foreach ( ?? ? gv in gasVehicles)
            {
                Console.WriteLine($"{gv.CurrentTankPercentage}");
            }

            foreach ( ?? ? gv in gasVehicles)
            {
                // This should completely refuel the gas tank
                gv.RefuelTank();
            }

            foreach ( ?? ? gv in gasVehicles)
            {
                Console.WriteLine($"{gv.CurrentTankPercentage}");
            }
        }
    }
}