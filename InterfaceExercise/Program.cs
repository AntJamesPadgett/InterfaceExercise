using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    public class Program
    {

        public static void Main(string[] args)
        {
            Car car = new Car();
            Truck truck = new Truck();
            var vehicles = new List<IVehicle>() { car, truck };

            
            foreach (var vehicle in Vehicles)
            {
                vehicle.Drive();
                vehicle.ChangedGears(true);
                vehicle.Reverse();
            }
        }
    }
}