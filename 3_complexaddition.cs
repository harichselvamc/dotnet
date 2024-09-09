using System;

namespace ComplexNumberAddition
{
    class Complex
    {
        public double Real { get; }
        public double Imaginary { get; }

        public Complex(double real, double imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }

        // Overload the + operator to add two Complex numbers
        public static Complex operator +(Complex c1, Complex c2)
        {
            return new Complex(c1.Real + c2.Real, c1.Imaginary + c2.Imaginary);
        }

        // Convert Complex number to string
        public override string ToString()
        {
            return $"{Real} + {Imaginary}i";
        }

        // Parse a string to create a Complex object
        public static Complex Parse(string complex)
        {
            complex = complex.Replace(" ", "");

            int signIndex = complex.IndexOf('+', 1);
            if (signIndex == -1) signIndex = complex.LastIndexOf('-', 1);

            string realPart = complex.Substring(0, signIndex);
            string imagPart = complex.Substring(signIndex).Replace("i", "");

            double real = double.Parse(realPart);
            double imag = double.Parse(imagPart);

            return new Complex(real, imag);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Get input from the user
            Console.Write("Enter the first complex number (e.g., 3 + 4i): ");
            string complex1Input = Console.ReadLine();
            Console.Write("Enter the second complex number (e.g., 1 + 2i): ");
            string complex2Input = Console.ReadLine();

            // Parse the input strings to create Complex objects
            Complex complex1 = Complex.Parse(complex1Input);
            Complex complex2 = Complex.Parse(complex2Input);

            // Add the complex numbers using the overloaded + operator
            Complex result = complex1 + complex2;

            // Display the result
            Console.WriteLine("The sum of the complex numbers is: " + result);
        }
    }
}
