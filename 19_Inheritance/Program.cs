using System;

namespace _19_Inheritance
{
    class Vehicle  // base class (parent) 
    {
        public string brand = "Ford";  // Vehicle field
        public void honk()             // Vehicle method 
        {                    
            Console.WriteLine("Tuut, tuut!");
        }
    }

    class Car : Vehicle  // derived class (child)
    {
        public string modelName = "Mustang";  // Car field
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("INHERITANCE\n");

            /*
            KNOWLEDGE CLOUD:

            1) Inhertiance is the process of inheriting the properties and methods of a one class into another.
            2) Base Class (parent class) : the class being inherited from
            3) Derived Class (child class) : the class that inherits from another class
            */

            // Create a myCar object
            Car myCar = new Car();

            // Call the honk() method (From the Vehicle class) on the myCar object
            myCar.honk();

            // Display the value of the brand field (from the Vehicle class) and the value of the modelName from the Car class
            Console.WriteLine("Car Brand: " + myCar.brand + " | Car Model: " + myCar.modelName);

            /*
            IMPORTANT NOTE: sealed keyword

            1) If you do not want other classes to inherit from a class, use the sealed keyword
            2) SYNTAX:
                        sealed class Vehicle 
                        {
                            ...
                        }

            */

            /*
            OUTPUT:

            INHERITANCE

            Tuut, tuut!
            Car Brand: Ford | Car Model: Mustang
            */
        }
    }
}
