using System;

namespace gary_garage
{
    class Program
    {
        static void Main(string[] args)
        {
            Ram Truck = new Ram();
            Truck.MainColor = "blue";
            Truck.MaximumOccupancy = 5;

            Cessna Jet = new Cessna();
            Jet.MainColor = "white";
            Jet.MaximumOccupancy = 12;

            Seadoo Boat = new Seadoo();
            Boat.MainColor = "grey";
            Boat.MaximumOccupancy = 4;

            Tesla Car = new Tesla();
            Car.MainColor = "black";
            Car.MaximumOccupancy = 4;

            Drive(Truck);
            Drive(Jet);
            Drive(Boat);
            Drive(Car);
            Console.WriteLine("");
            Turn(Truck);
            Turn(Jet);
            Turn(Boat);
            Turn(Car);
            Console.WriteLine("");
            Stop(Truck);
            Stop(Jet);
            Stop(Boat);
            Stop(Car);

        }

        static void Drive(Vehicle aVehicle)
        {
            aVehicle.Drive();
        }

        static void Turn(Vehicle aVehicle)
        {
            aVehicle.Turn();
        }
        static void Stop(Vehicle aVehicle)
        {
            aVehicle.Stop();
        }

    }
}