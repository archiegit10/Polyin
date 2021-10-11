using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyIn
{
    class Showroom<T> where T : Vehicle
    {
        T value;
        public Showroom(T value)
        {
            this.value = value;
        }
        public void ShowVehicle()
        {
            Console.WriteLine(value.ToString());
        }
    }
}
