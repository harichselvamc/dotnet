using System;

namespace ComplexNumberAddition
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first complex number: ");
            string complex1 = Console.ReadLine();
            Console.Write("Enter the second complex number: ");
            string complex2 = Console.ReadLine();
            (double real1, double imag1) = ParseComplexNumber(complex1);
            (double real2, double imag2) = ParseComplexNumber(complex2);

            double realSum = real1 + real2;
            double imagSum = imag1 + imag2;
            Console.WriteLine("The sum of the complex numbers is: " + realSum + " + " + imagSum + "i");
        }

        static (double, double) ParseComplexNumber(string complex)
        {
            
            complex = complex.Replace(" ", "");

         
            int signIndex = complex.IndexOf('+', 1);
            if (signIndex == -1) signIndex = complex.LastIndexOf('-', 1); 

            string realPart = complex.Substring(0, signIndex);
            string imagPart = complex.Substring(signIndex).Replace("i", "");
            double real = double.Parse(realPart);
            double imag = double.Parse(imagPart);

            return (real, imag);
        }
    }
}
