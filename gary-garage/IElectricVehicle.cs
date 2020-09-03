using System;

namespace gary_garage
{
    public interface IElectricVehicle
    {
        int CurrentChargePercentage { get; set; }

        void ChargeBattery();

    }
}