using System;


class MatrixShuffling
{
    static void PrintTheMatrix(string[,] matrix )
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0 } ", matrix[row, col]);
            }
            Console.WriteLine();
        }
    }
    static void Main()
    {
        // CONDITION OF THE TASK
        // Write a program which reads a string matrix from the console and performs certain operations with its elements. User input is provided like in the problem above – first you read the dimensions and then the data. Remember, you are not required to do this step first, you may add this functionality later. Your program should then receive commands in format: "swap x1 y1 x2 y2" where x1, x2, y1, y2 are coordinates in the matrix. In order for a command to be valid, it should start with the "swap" keyword along with four valid coordinates (no more, no less). You should swap the values at the given coordinates (cell [x1, y1] with cell [x2, y2]) and print the matrix at each step (thus you'll be able to check if the operation was performed correctly). If the command is not valid (doesn't contain the keyword "swap", has fewer or more coordinates entered or the given coordinates do not exist), print "Invalid input!" and move on to the next command. Your program should finish when the string "END" is entered. 


        // reading the dimensions of the matrix
        int rows = int.Parse(Console.ReadLine());
        int cols = int.Parse(Console.ReadLine());
        string[,] matrix = new string[rows, cols];

        // reading the cells of the matrix

        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                matrix[row, col] = Console.ReadLine();
            }
        }

        // receiving commands

        string[] command = Console.ReadLine().Split(' ');
        while(command[0] != "END" && command[0] != "end")
        {
          
            if (command[0] == "swap")
            {
                int rowToSwap = int.Parse(command[1]);
                int colToSwap = int.Parse(command[2]);

                int rowToSwapWith = int.Parse(command[3]);
                int colToSwapWith = int.Parse(command[4]);

                if ((rowToSwap > rows || rowToSwap < 0) || (colToSwap > cols || colToSwap < 0) || (rowToSwapWith > rows || rowToSwapWith < 0) || (colToSwapWith > cols || colToSwapWith < 0)) // checking for invalid values
                {
                    Console.WriteLine("Invalid Input");
                }
                else
                {
                   
                    // swapping
                    string container = matrix[rowToSwap, colToSwap];
                    matrix[rowToSwap, colToSwap] = matrix[rowToSwapWith, colToSwapWith];
                    matrix[rowToSwapWith, colToSwapWith] = container;
                    // printing
                    PrintTheMatrix(matrix);

                }
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
            command = Console.ReadLine().Split();
        }


    }

    
}

