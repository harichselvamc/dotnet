using System;

namespace FibonacciSeries
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the limit for Fibonacci series: ");
            int limit = int.Parse(Console.ReadLine());

            int a = 0, b = 1, c;

            Console.WriteLine("Fibonacci Series up to " + limit + ":");
            for (int i = 0; i < limit; i++)
            {
                Console.Write(a + " ");
                c = a + b;
                a = b;
                b = c;
            }
        }
    }
}
