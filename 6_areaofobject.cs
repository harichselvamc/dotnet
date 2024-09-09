using System;

namespace AreaOfAnObject
{
    // Step 2: Create an interface Area and declare a method compute
    interface IArea
    {
        double Compute(double x);
    }

    // Step 3: Define the Square class implementing IArea
    class Square : IArea
    {
        // Step 4: Define the method of the interface in Square class
        public double Compute(double x)
        {
            return x * x;
        }
    }

    // Step 3: Define the Circle class implementing IArea
    class Circle : IArea
    {
        // Step 4: Define the method of the interface in Circle class
        public double Compute(double x)
        {
            return Math.PI * x * x;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Step 6: Display the result as per the given value
            Square square = new Square();
            Circle circle = new Circle();

            // Perform the necessary calculation and display the results
            Console.WriteLine("Enter the side length of the square: ");
            double side = double.Parse(Console.ReadLine());
            Console.WriteLine("Area of Square = " + square.Compute(side));

            Console.WriteLine("Enter the radius of the circle: ");
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine("Area of Circle = " + circle.Compute(radius));

            // Step 7: Stop the program
            Console.ReadLine();
        }
    }
}
