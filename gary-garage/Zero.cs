using System;

namespace gary_garage
{
    public class Zero : Vehicle, IElectricVehicle
    {
        public double BatteryKWh { get; set; }
        public int CurrentChargePercentage { get; set; }

        public void ChargeBattery()
        {
            CurrentChargePercentage = 100;
        }
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Zero zipped passed you");
        }
        public override void Turn()
        {
            Console.WriteLine("The vehicle turned right.");
        }
        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Zero gently rolled to a stop");
        }
    }

}