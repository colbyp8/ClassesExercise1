using System;
using System.Collections.Generic;

namespace BasicClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "Toyota";
            myCar.Model = "4-Runner";
            myCar.Year = 2000;

            var mazda = new Car()
            {
                Make = "Mazda",
                Model = "CX-5",
                Year = 2016
            };

            var chevy = new Car("Chevy", "Impala", 2001);

            var carList = new List<Car>() { myCar, mazda, chevy };

            foreach( var car in carList )
            {
                Console.WriteLine($"Make: {car.Make}");
                Console.WriteLine($"Model: {car.Model}");
                Console.WriteLine($"Year: {car.Year}");
            }
        }
    }
}
