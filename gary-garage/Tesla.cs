using System;

namespace gary_garage
{
    public class Tesla : Vehicle, IElectricVehicle
    {
        public double BatteryKWh { get; set; }

        public int CurrentChargePercentage { get; set; }

        public void Charge()
        {
            CurrentChargePercentage = 100;
        }
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Tesla drove silently passed by");
        }
        public override void Turn()
        {
            Console.WriteLine("The vehicle turned right.");
        }
        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Tesla came to a stop");
        }
    }

}