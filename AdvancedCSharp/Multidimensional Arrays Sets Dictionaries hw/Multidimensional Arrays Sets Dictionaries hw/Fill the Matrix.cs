using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multidimensional_Arrays__Sets__Dictionaries
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int countRow = 0;

            int[,] matrix1 = new int[n, n];

            for (int row = 0; row < matrix1.GetLength(0); row++)
            {
                for (int col = 0; col < matrix1.GetLength(1); col++)
                {
                    countRow++;
                    if (row % 2 == 0)
                    {
                        matrix1[col, row] = countRow;
                    }
                    else
                    {
                        matrix1[matrix1.GetLength(0) - col - 1, row] = countRow;
                    }
                }
            }

            PrintMatrix(matrix1);
        }
        static void PrintMatrix(int[,] matrix1)
        {
            for (int row = 0; row < matrix1.GetLength(0); row++)
            {
                for (int col = 0; col < matrix1.GetLength(1); col++)
                {
                    Console.Write(" {0}", matrix1[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
