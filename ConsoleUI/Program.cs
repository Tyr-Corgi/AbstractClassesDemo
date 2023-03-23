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
             * Todo follow all comments!! 
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties Year, Make, and Model
             * Set the defaults to something generic in the Vehicle class
             
             * Vehicle shall have an abstract method called DriveAbstract with no implementation - Done
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation. - Done
             */

            Vehicle Sienna = new Car() { Year = "2022", Make = "Toyota", Model = "Sienna" };


            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle - Done
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle - Done
             * Provide the implementations for the abstract methods - done
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles
            var myList = new List<Vehicle>();
            Vehicle Truck = new Car() { HasTrunk = true, Make = "Ford", Model = "F150", Year = "2022" };
            var SUV = new Car() { HasTrunk = true, Make = "Lexus", Model = "RX450", Year = "2010" };

            Vehicle SuperSport = new Motorcycle() { HasSideCart = false, Make = "Kawasaki", Model = "Ninja", Year = "2005" };
            var Cruiser = new Motorcycle() { HasSideCart = true, Make = "Harley-Davidson", Model = "750", Year = "2013" };
            myList.Add(Truck);
            myList.Add(SUV);
            myList.Add(SuperSport);
            myList.Add(Cruiser);


            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * 
             * Set the properties with object initializer syntax
             */

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */

            foreach (var Vehicle in myList)
            {
                Console.WriteLine($"{Vehicle.Year}");
                Console.WriteLine($"{Vehicle.Make}");
                Console.WriteLine($"{Vehicle.Model}");
                Console.WriteLine();


            }

            // Call each of the drive methods for one car and one motorcycle

            #endregion            
            Console.ReadLine();
        }
    }
}
