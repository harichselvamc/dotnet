using System;

namespace StructExample
{
    // Define a structure named 'employee'
    struct Employee
    {
        // Member variables
        int id;
        double salary;

        // Constructor to initialize id and salary
        public Employee(int id, double salary)
        {
            this.id = id;
            this.salary = salary;
        }

        // Overloaded constructor to initialize with a fixed salary
        public Employee(int id)
        {
            this.id = id;
            this.salary = 3400.00; // Default salary
        }

        // Copy constructor
        public Employee(Employee emp)
        {
            this.id = emp.id;
            this.salary = emp.salary;
        }

        // Method to display the values of id and salary
        public void DisplayValues()
        {
            Console.WriteLine("Structure:");
            Console.WriteLine("ID: " + this.id);
            Console.WriteLine("Salary: " + this.salary);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the Employee structure
            Employee emp = new Employee(12, 4560.00);

            // Display the values of the employee instance
            emp.DisplayValues();

            Console.ReadLine(); // Wait for user input before closing the console window
        }
    }
}
