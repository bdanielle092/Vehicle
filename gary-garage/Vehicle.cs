using System;

namespace gary_garage
{
    public class Vehicle
    {
        public string MainColor { get; set; }
        public int MaximumOccupancy { get; set; }
        public virtual void Drive()
        {
            Console.WriteLine("The white Cessna swished through the air!");
        }

        public virtual void Turn()
        {
            Console.WriteLine("The vehicle turned Left");
        }

        public virtual void Stop()
        {
            Console.WriteLine("The white Cessna rolls to a stop after rolling a mile down the runway.");
        }
    }
}