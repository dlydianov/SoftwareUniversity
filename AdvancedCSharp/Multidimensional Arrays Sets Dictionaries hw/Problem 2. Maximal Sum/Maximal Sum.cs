using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.Maximal_Sum
{
    class Program
    {
        static void Main()
        {
            int[] matrixLenght = Array.ConvertAll(Console.ReadLine().Split(' '), s => int.Parse(s));
            int[,] matrix = new int[matrixLenght[0], matrixLenght[1]];
            int count = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] fill = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                count = 0;
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = fill[count];
                    count++;
                }
            }

            int bestSum = int.MinValue;
            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    int sum = matrix[row, col] +
                              matrix[row, col + 1] +
                              matrix[row, col + 2] +
                              matrix[row + 1, col] +
                              matrix[row + 1, col + 1] +
                              matrix[row + 1, col + 2] +
                              matrix[row + 2, col] +
                              matrix[row + 2, col + 1] +
                              matrix[row + 2, col + 2];
                    if (sum > bestSum)
                    {
                        bestSum = sum;
                    }

                }
            }
            Console.WriteLine(bestSum);

        }
    }
}
