using System;

class FillTheMatrix
{
    static void Main()
    {
        // Write two programs that fill and print a matrix of size N x N. Filling a matrix in the regular pattern (top to bottom and left to right) is boring. 

        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];
        int fill = 1;

        // pattern A;
        for (int col = 0; col < n; col++)
        {
            for (int row = 0; row < n; row++)
            {
                matrix[row, col] = fill;
                fill++;
            }
        }

        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                Console.Write("{0, 4}",matrix[row, col] + " ");
            }
            Console.WriteLine();
        }

        // pattern B;

        Console.WriteLine();
        Console.WriteLine();

        string direction = "down";
        fill = 1; // I am restarting my fill variable for the second matrix;
        int line = 0; // row
        int position = 0; // col
        while(fill <= n * n) // this shows how many numbers is in the matrix and I am going to use it for my counter
        {
            while (direction == "down")
            {
                matrix[line, position] = fill;
                fill++;
                line++;
                if(line >= n)
                {
                    direction = "up";
                    line--;
                    position++;
                    break;
                }
            }
            while (direction == "up")
            {
                matrix[line, position] = fill;
                fill++;
                line--;
                if(line <0)
                {
                    position++;
                    line++;
                    direction = "down";
                    break;
                }
            }
        }

        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                Console.Write("{0, 4}", matrix[row, col] + " ");
            }
            Console.WriteLine();
        }

    }
}

