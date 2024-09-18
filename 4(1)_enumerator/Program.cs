using System;

namespace EnumeratorExample
{
    class Area
    {
        // Declare the enum for Shape
        public enum Shape
        {
            Circle, // Enum value for Circle
            Square  // Enum value for Square
        }

        // Method to calculate and display the area based on shape
        public void CalculateArea(int x, Shape shape)
        {
            double area;
            switch (shape)
            {
                case Shape.Circle:
                    area = Math.PI * x * x;
                    Console.WriteLine($"Area of the circle with radius {x}: {area:F2}");
                    break;
                case Shape.Square:
                    area = x * x;
                    Console.WriteLine($"Area of the square with side length {x}: {area:F2}");
                    break;
                default:
                    Console.WriteLine("Invalid shape.");
                    break;
            }
        }
    }

    class EnumTest
    {
        static void Main(string[] args)
        {
            Area area = new Area();

            // Get shape input from the user with validation
            Area.Shape shape;
            while (true)
            {
                Console.WriteLine("Enter the shape (Circle or Square): ");
                string shapeInput = Console.ReadLine();

                if (Enum.TryParse(shapeInput, true, out shape) && Enum.IsDefined(typeof(Area.Shape), shape))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter 'Circle' or 'Square'.");
                }
            }

            // Get size input from the user with validation
            int size;
            while (true)
            {
                Console.WriteLine("Enter the size (radius for Circle, side length for Square): ");
                if (int.TryParse(Console.ReadLine(), out size) && size > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a positive integer.");
                }
            }

            // Calculate and display the area
            area.CalculateArea(size, shape);

            Console.ReadLine(); // Wait for user input before closing the console window
        }
    }
}
