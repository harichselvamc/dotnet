using System;

interface IPerson
{
    string Name { get; set; }
}

interface IEmployee
{
    int EmployeeId { get; set; }
    void DisplayEmployeeDetails();
}

class Employee : IPerson, IEmployee
{
    public string Name { get; set; }
    public int EmployeeId { get; set; }

    public void DisplayEmployeeDetails()
    {
        Console.WriteLine("Employee Name: " + Name);
        Console.WriteLine("Employee ID: " + EmployeeId);
    }
}

public class Program
{
    public static void Main()
    {
        Employee employee = new Employee
        {
            Name = "Manikanta",
            EmployeeId = 12345
        };

        employee.DisplayEmployeeDetails();
    }
}
