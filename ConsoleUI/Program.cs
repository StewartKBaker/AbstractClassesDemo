using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo: Follow all comments!! 
             * Double click on the region (gray box) to view all comments
             */

            #region Vehicles

            /*
             * -Create an abstract class called Vehicle
             * -The vehicle class shall have three string properties: Year, Make, and Model
             * -Set the defaults of the properties to something generic in the Vehicle class
             * -Vehicle class shall have an abstract method called DriveAbstract with no implementation.
             * -Vehicle class shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * -Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * -Add a distinct property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * -Provide the implementations for the abstract methods
             * -Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles
            List<Vehicle> vehicles = new List<Vehicle>();
            /*
             * -Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * 
             * -Set the properties values with object initializer syntax
             */
            Car car1 = new Car() { Make = "Toyota", Model = "Tacoma", Year = "2017", HasFourDoors = true };
            Motorcycle motorcycle1 = new Motorcycle() { Make = "Kawasaki", Model = "Ninja 600", Year = "2023", Has2Wheels = true};
            Vehicle vehicle1 = new Car() { Make = "Lexus", Model = "RC 350", Year = "2022", HasFourDoors = false };
            Vehicle vehicle2 = new Motorcycle() { Make = "Can-Am", Model = "Spyder F3", Year = "2020", Has2Wheels = false };

            vehicles.Add(car1);
            vehicles.Add(motorcycle1);
            vehicles.Add(vehicle1);
            vehicles.Add(vehicle2);
            /*
             * -Add the 4 vehicles to the list
             * -Using a foreach loop iterate through the list and display each of the properties
             */
            var numberVehicle = 0;
            foreach (var vehicle in vehicles)
            {
             numberVehicle++;
             Console.WriteLine($"{numberVehicle}. {vehicle.Year} {vehicle.Make} {vehicle.Model} \n{vehicle.ExtraInfo()}");
             Console.WriteLine("");
            }
            // -Call each of the drive methods for one car and one motorcycle
            Console.WriteLine($"\nCar 1:");
            car1.DriveVirtual();
            car1.DriveAbstract();
            
            Console.WriteLine($"\nMotorcycle 2:");
            motorcycle1.DriveVirtual();
            motorcycle1.DriveAbstract();
            #endregion            
            Console.ReadLine();
        }
    }
}
