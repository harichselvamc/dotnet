using System;

namespace StudentStatus
{
    // Define a structure to hold student information
    struct Student
    {
        public string Name;
        public long RegNo;
        public string Dept;
        public int[] Marks;

        // Method to display student information
        public void DisplayInfo()
        {
            Console.WriteLine("\nStudent Information:");
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Registration Number: " + RegNo);
            Console.WriteLine("Department: " + Dept);
            
            int totalMarks = 0;
            for (int i = 0; i < Marks.Length; i++)
            {
                totalMarks += Marks[i];
            }

            double averageMarks = (double)totalMarks / Marks.Length;
            Console.WriteLine("Total Marks: " + totalMarks);
            Console.WriteLine("Average Marks: " + averageMarks);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create a Student instance
            Student student;

            // Ask for student information
            Console.Write("Enter student name: ");
            student.Name = Console.ReadLine();
            Console.Write("Enter registration number: ");
            student.RegNo = long.Parse(Console.ReadLine());
            Console.Write("Enter department: ");
            student.Dept = Console.ReadLine();

            // Ask for subject marks
            student.Marks = new int[5];
            Console.WriteLine("Enter the 5 subject marks:");
            for (int i = 0; i < student.Marks.Length; i++)
            {
                Console.Write($"Subject {i + 1} Marks: ");
                student.Marks[i] = int.Parse(Console.ReadLine());
            }

            // Display the student information
            student.DisplayInfo();
        }
    }
}
