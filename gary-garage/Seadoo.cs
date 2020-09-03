using System;

namespace gary_garage
{
    public class Seadoo : Vehicle, IGasVehicle
    {
        public double FuelCapacity { get; set; }
        public int CurrentTankPercentage { get; set; }
        public void RefuelTank()
        {
            CurrentTankPercentage = 100;
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Seadoo slapshed by!");
        }
        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Seadoo gently came to a stop");
        }

    }

}