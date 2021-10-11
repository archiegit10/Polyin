using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyIn
{
    sealed class Car : Vehicle
    {
        public int NumOfDoors { get; set; }

        public Car(int num)
        {
            NumOfDoors = num;
        }
        public override void Drive()
        {
            Console.WriteLine("Vroom vroom");
        }

    }
}
