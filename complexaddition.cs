using System;

namespace ComplexNumberAddition
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read the first complex number
            Console.Write("Enter the real part of the first complex number: ");
            double real1 = double.Parse(Console.ReadLine());
            Console.Write("Enter the imaginary part of the first complex number: ");
            double imag1 = double.Parse(Console.ReadLine());

            // Read the second complex number
            Console.Write("Enter the real part of the second complex number: ");
            double real2 = double.Parse(Console.ReadLine());
            Console.Write("Enter the imaginary part of the second complex number: ");
            double imag2 = double.Parse(Console.ReadLine());

            // Add the complex numbers
            double realSum = real1 + real2;
            double imagSum = imag1 + imag2;

            // Display the result
            Console.WriteLine("The sum of the complex numbers is: " + realSum + " + " + imagSum + "i");
        }
    }
}
