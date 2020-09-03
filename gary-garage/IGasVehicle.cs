using System;

namespace gary_garage
{
    public interface IGasVehicle
    {
        int CurrentTankPercentage { get; set; }
        void RefuelTank();
    }
}