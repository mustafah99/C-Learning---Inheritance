using System;
using static System.Console;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            string carName = ReadLine();  
            
            string carModel = ReadLine();

            Car newCar = new Car(carName, carModel);

            Console.WriteLine("C# Inheritance");

            // In C# it is possible to inherit fields and methods from one class to another.

            // We group the "inheritance" concept of C# into two categories.
            // Derived Class (child) - this is the class that inherits from another class.
            // Base Class (parent) this is the class that is being derived from.

            // In order to inherit from a class, we use the : symbol.

            // See examples below.

            // Creating a myCar object.

            //myCar.carHonk();

            WriteLine($"My car is a {newCar.modelName} {newCar.brand}");
        }

        class Vehicle // Base Class (Parent)
        {
            public string brand;
            public void carHonk()
            {
                WriteLine("Honk, honk");
            }
        }
        class Car : Vehicle // Derived Class (Child/ Inheritor)
        {
            public string modelName = "Model S";

            public Car(string x, string y)
            {
                modelName = x;
                brand = y;
            }
        }
    }
}
