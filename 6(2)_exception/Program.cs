using System;

class Program
{
    static void Main()
    {
        string vname;
        int age;

        try
        {
            Console.Write("Enter your Name: ");
            vname = Console.ReadLine();

            Console.Write("Enter your Age: ");
            age = Int32.Parse(Console.ReadLine());

            if (age >= 18)
            {
                Console.WriteLine($"Hi {vname}, Your age is greater than 18, so you are eligible to vote.");
            }
            else
            {
                Console.WriteLine($"Sorry {vname}, Your age is less than 18, so you are not eligible to vote.");
            }
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Invalid input format. Please enter a valid number for age.");
            Console.WriteLine("Exception: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred.");
            Console.WriteLine("Exception: " + ex.Message);
        }

        Console.ReadLine(); // Wait for user to press Enter before closing
    }
}
