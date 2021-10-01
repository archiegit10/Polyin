using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyIn
{
    class Vehicle
    {
        private string vehicleMake;
        private string vehicleModel;
        private string vehicleColour;
        public string vehicleType;
        public int vehicleId;

        public string make
        {
            get {return vehicleMake;}
            set{vehicleMake = value;}
        }
        public string model
        {
            get { return vehicleModel; }
            set { vehicleModel = value; }
        }
        public string colour
        {
            get { return vehicleColour; }
            set { vehicleColour = value; }
        }

        internal class Car : Vehicle
        {
            public string getInfo()
            {
               return $"\nCar details ID: {vehicleId} Type: {vehicleType}\nCar Description: {vehicleModel} {vehicleMake} in {vehicleColour} ";
            }
        }

        internal class Motorbike : Vehicle
        {
            public string getInfo()
            {
                return $"\nMotorbike details ID: {vehicleId} Type: {vehicleType}\nMotorbike Description: {vehicleModel} {vehicleMake} in {vehicleColour} ";
            }
        }

        internal class Truck : Vehicle
        {
            public string getInfo()
            {
                return $"\nTruck details ID: {vehicleId} Type: {vehicleType}\nTruck Description: {vehicleModel} {vehicleMake} in {vehicleColour} ";
            }
        }
    }
}
