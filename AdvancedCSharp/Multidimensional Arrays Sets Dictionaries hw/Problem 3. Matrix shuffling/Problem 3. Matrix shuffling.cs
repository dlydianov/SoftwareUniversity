using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.Matrix_shuffling
{
    class Program
    {
        static void Main()
        {
            int[] matrixLenght = Array.ConvertAll(Console.ReadLine().Split(' '), s => int.Parse(s));
            int[,] matrix = new int[matrixLenght[0], matrixLenght[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    int number = int.Parse(Console.ReadLine());
                    matrix[row, col] = number;
                }
            }
            string[] inputSwap = Console.ReadLine().Split(' ').ToArray();
            while (inputSwap[0] != "END")
            {
                if (inputSwap[0] != "swap")
                {
                    Console.WriteLine("Invalid input");
                }
                else
                {
                    int temp = matrix[int.Parse(inputSwap[3]),int.Parse(inputSwap[4])];
                    matrix[int.Parse(inputSwap[3]), int.Parse(inputSwap[4])] = matrix[int.Parse(inputSwap[1]),int.Parse(inputSwap[2])];
                    matrix[int.Parse(inputSwap[1]), int.Parse(inputSwap[2])] = temp;
                    MatrixPrint(matrix);
                }
            inputSwap = Console.ReadLine().Split(' ').ToArray();
            }
        }
        static void MatrixPrint (int[,] m)
        {
            for (int row = 0; row < m.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < m.GetLength(1) - 1; col++)
                {
                    Console.Write(m[row,col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
