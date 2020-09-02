using System;

namespace gary_garage
{
    public class Ram : Vehicle
    {
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
            Console.WriteLine();
        }
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Ram zoomed passed");
        }
        public override void Turn()
        {
            Console.WriteLine("The vehicle took a sharp right turn.");
        }
        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Ram stopped quickly.");
        }

    }

}