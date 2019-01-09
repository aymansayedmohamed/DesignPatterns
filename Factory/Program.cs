using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    /*
     
     the factory method pattern is a creational pattern that uses factory methods to deal with 
     the problem of creating objects without having to specify the exact class of the object that will be created. 
     
     - A class can’t anticipate which class objects it must create
     - A class uses its subclasses to specify which objects it creates
     - You need to localize the knowledge of which class gets created
         
     */
    class Program
    {
        static void Main(string[] args)
        {
            IVehicleFactory carCreator = new VehicleFactory();

           var car = carCreator.Build(CarType.Car);
            Console.WriteLine($"Car wheels count: {car.wheelsCount}");

           var motorbike = carCreator.Build(CarType.Motorbike);
            Console.WriteLine($"Motorbike wheels count: {motorbike.wheelsCount}");

            var truck = carCreator.Build(CarType.Truck);
            Console.WriteLine($"Truck wheels count: {truck.wheelsCount}");

        }
    }
}
