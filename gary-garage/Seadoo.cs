using System;

namespace gary_garage
{
    public class Seadoo : Vehicle
    {
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
            Console.WriteLine();
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