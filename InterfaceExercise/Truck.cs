using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
     public class Truck : IVehicle,ICompany
    {
        public string CompanyName { get; set; }
        public string Motto { get; set; } = "Built Ford Tough";
        public double EngineSize { get; set; } = 6.8;
        public string Model { get; set; } = "Ford";
        public string Make { get; set; } = "F150";
        public int SeatCount { get; set; } = 5;
        public bool HasChangedGears { get; set; }
        public bool HasFourWheelDrive { get; set; }

        public void Drive()
        {
            Console.WriteLine($"{GetType().Name} now driving forward. . .");
        }

        public void Reverse()
        {
            if (HasChangedGears == true)
            {


                Console.WriteLine($"{GetType().Name} now driving reversing.  .  .");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine("Cant reverse until we change gears");
            }
        }

        public void Park()
        {
            if (HasChangedGears == true)
            {


                Console.WriteLine($"{GetType().Name} now in park.  .  .");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine("Cant park until we change gears");
            }
        }

        public void ChangedGears(bool isChanged)
        {
            HasChangedGears = isChanged;
        }
    }
}
}
