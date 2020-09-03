using System;

namespace gary_garage
{
    public class Ram : Vehicle, IGasVehicle
    {
        // properties of your vehicle 
        public double FuelCapacity { get; set; }
        public int CurrentTankPercentage { get; set; }

        // method for refueling the tank 
        public void RefuelTank()
        {
            CurrentTankPercentage = 100;
        }
        // method for driving your Vehicle which has been overridden 
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Ram zoomed passed");
        }
        // method for turning your Vehicle which has been overridden
        public override void Turn()
        {
            Console.WriteLine("The vehicle took a sharp right turn.");
        }
        // method for stopping your vehicle which has been overridden
        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Ram stopped quickly.");
        }

    }

}