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
            lorry.vehicleId = 10;
            lorry.vehicleType = "Truck";
            Console.WriteLine(lorry.getInfo());

            Vehicle.Motorbike bicycle = new Vehicle.Motorbike();
            bicycle.model = "pedals";
            bicycle.make = "b&q";
            bicycle.colour = "red";
            bicycle.vehicleId = 1;
            bicycle.vehicleType = "Motorbike";
            Console.WriteLine(bicycle.getInfo());

            //Vehicle.bicycle = Garage.
            Showroom<Car> showroom = new Showroom<Car>(new Car(1));
            showroom.ShowVehicle();


            int[] arr = { 1, 2, 3, 4 };
            CustomArrayList<int> arrList = new CustomArrayList<int>(arr);
            arrList.PrintValues();
            int val = arrList.Pop();
            Console.WriteLine($"Popped value is {val}");
            arrList.PrintValues();

            string[] strArr = { "Helo", "world" };
            CustomArrayList<string> strList = new CustomArrayList<string>(strArr);
            strList.PrintValues();

            Vehicle v1 = new Car(1);
            IDriveable driveableThing = v1;
            driveableThing.Drive();

            DriveThing(new Car(1));

        }
        public static void DriveThing(IDriveable driveable)
        {
            driveable.Drive();
        }
    }
}
