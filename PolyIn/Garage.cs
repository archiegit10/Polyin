using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyIn
{
    class Garage
    {
        IList<Vehicle> vehicles = new List<Vehicle>();
        public string vehicleMake;
        public string vehicleModel;
        public string vehicleColour;
        public string vehicleType;
        public int vehicleId;
        public void AddVehicle(string vehicleMake, string vehicleModel, string vehicleColour, string vehicleType, int vehicleId)
        {
            Vehicle tempVehicle = new Vehicle();
            vehicles.Add(tempVehicle);
        }
        public void RemoveVehicle()
        {

        }

        public void RemoveType()
        {

        }
        public void EmptyGarage()
        {

        }
    }
}
