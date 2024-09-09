using System;

namespace MatrixAddition
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read the dimensions of the matrices
            Console.Write("Enter the number of rows: ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("Enter the number of columns: ");
            int cols = int.Parse(Console.ReadLine());

            // Initialize the matrices
            int[,] matrix1 = new int[rows, cols];
            int[,] matrix2 = new int[rows, cols];
            int[,] result = new int[rows, cols];

            // Read the first matrix
            Console.WriteLine("Enter the elements of the first matrix:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"Element [{i},{j}]: ");
                    matrix1[i, j] = int.Parse(Console.ReadLine());
                }
            }

            // Read the second matrix
            Console.WriteLine("Enter the elements of the second matrix:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"Element [{i},{j}]: ");
                    matrix2[i, j] = int.Parse(Console.ReadLine());
                }
            }

            // Add the matrices
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }

            // Display the result
            Console.WriteLine("The resulting matrix is:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(result[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
