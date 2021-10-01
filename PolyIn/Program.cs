using System;

namespace PolyIn
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Triangle triangle1 = new Triangle();
            
            Console.WriteLine($"Area of a triange is: {triangle1.getArea(10, 10)}");

            
            Vehicle.Car clio = new Vehicle.Car();
            clio.model = "Clio";
            clio.make = "Renault";
            clio.colour = "Silver";
            clio.vehicleId = 50;
            clio.vehicleType = "Car";
            Console.WriteLine(clio.getInfo());

            Vehicle.Truck lorry = new Vehicle.Truck();
            lorry.model = "Lorry";
            lorry.make = "Truck";
            lorry.colour = "Black";
            clio.vehicleId = 10;
            clio.vehicleType = "Truck";
            Console.WriteLine(lorry.getInfo());

            Vehicle.Motorbike bicycle = new Vehicle.Motorbike();
            bicycle.model = "pedals";
            bicycle.make = "b&q";
            bicycle.colour = "red";
            clio.vehicleId = 1;
            clio.vehicleType = "Motorbike";
            Console.WriteLine(bicycle.getInfo());

        }
    }
}
