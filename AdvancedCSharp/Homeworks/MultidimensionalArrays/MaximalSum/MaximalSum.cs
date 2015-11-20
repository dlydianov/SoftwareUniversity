using System;



class MaximalSum
{
    static int SumOfRectangular(int[,] matrix, int row, int col)
    {
        int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

        return sum;
    }
    static void PrintingMatrix(int[,] matrix, int bestRow, int bestCol)
    {
        for (int row = bestRow; row <= bestRow + 2; row++)
        {
            for (int col = bestCol; col <= bestCol + 2; col++)
            {
                Console.Write("{0, 4}", matrix[row, col]);
            }
            Console.WriteLine();
        }
    }
    static void Main()
    {
        // Write a program that reads a rectangular integer matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements. On the first line, you will receive the rows N and columns M. On the next N lines you will receive each row with its columns. Print the elements of the 3 x 3 square as a matrix, along with their sum.

        string[] RowAndColumn = Console.ReadLine().Split(' ');
        int rows = int.Parse(RowAndColumn[0]);
        int cols = int.Parse(RowAndColumn[1]);
        int[,] matrix = new int[rows, cols];

        // first part filling the matrix
        for (int row = 0; row < rows; row++)
        {
            string[] numbersOfRow = Console.ReadLine().Split(' ');
            int index = 0; // I will use this to fill the numbers from the input to the matrix.
            while(index < cols)
            {
                matrix[row, index] = int.Parse(numbersOfRow[index]);
                index++;
            }
        }

        // second part getting the sum of the rectangulars in the matrix
        int max = int.MinValue;
        int sum = 0;
        int bestRow = 0;
        int bestCol = 0;
        for (int row = 0; row <= rows - 3; row++)
        {
            for (int col = 0; col <= cols - 3; col++)
            {
                sum = SumOfRectangular(matrix, row, col);
                if(sum > max)
                {
                    max = sum;
                    bestRow = row;
                    bestCol = col;
                }
            }
        }

        // third part printing the result
        Console.WriteLine("Sum: {0}", max);
        PrintingMatrix(matrix, bestRow, bestCol);

    }  
}

