using System;

class SequenceInMatrix
{
    private static void PrintingResult(string[,] matrix, int bestRow, int bestCol, string bestDirection, int longestSet )
    {
        int counter = 0; // I use this counter in order to remove the last comma of result.
        if(longestSet > 1)
        {
            if (bestDirection == "horizontal")
            {

                for (int col = bestCol; col < bestCol + longestSet; col++)
                {
                    counter++;
                    if (counter < longestSet)
                    {
                        Console.Write("{0}, ", matrix[bestRow, col]);
                    }
                    else
                    {
                        Console.Write("{0}, ", matrix[bestRow, col]);
                    }
                   
                }

            }
            else if (bestDirection == "diagonalDown")
            {
                
                for (int row = bestRow; row < bestRow + longestSet; row++)
                {
                    for (int col = bestCol; col <= bestCol; col++)
                    {
                        counter++;
                        if (counter < longestSet)
                        {
                            Console.Write("{0}, ", matrix[row, col]);
                        }
                        else
                        {
                            Console.Write("{0} ", matrix[row, col]);
                        }
                    }
                    bestCol += 1;
                }
            }
            else if (bestDirection == "diagonalUp")
            {
                for (int row = bestRow; row > bestRow - longestSet; row--)
                {
                    for (int col = bestCol; col < bestCol + longestSet; col++)
                    {
                        counter++;
                        if (counter < longestSet)
                        {
                            Console.Write("{0}, ", matrix[row, col]);
                        }
                        else
                        {
                            Console.Write("{0} ", matrix[row, col]);
                        }
                    }
                }
            }
            else
            {
                for (int row = bestRow; row < bestRow + longestSet; row++)
                {
                    counter++;
                        if (counter < longestSet)
                        {
                            Console.Write("{0}, ", matrix[row, bestCol]);
                        }
                        else
                        {
                            Console.Write("{0} ", matrix[row, bestCol]);
                        }
                }
            }
        }
        else
        {
            Console.WriteLine("There isn't a set which is longer than the others");
        }
     
    }
    static void Main()
    {
        // CONDITION OF THE TASK
        // We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbour elements.

        // getting the details of the matrix
        int rows = int.Parse(Console.ReadLine());
        int cols = int.Parse(Console.ReadLine());
        string[,] matrix = new string[rows, cols];

        // reading the matrix
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                matrix[row, col] = Console.ReadLine();
            }
        }

        // iterating the matrix and taking the longest set.
        
        int bestRow = 0;
        int bestCol = 0;
        int longestSet = 0;
        string bestDirection = "";
        
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                // horizontal
                int set = 1;
                int line = row; // row
                int position = col; // col
                string direction = "horizontal";
                while (direction == "horizontal" && position < cols)
                {
                    position++;
                    while (position < cols && matrix[row, col] == matrix[line, position])
                    {
                        set++;
                        if (set > longestSet)
                        {
                            longestSet = set;
                            bestDirection = direction;
                            bestRow = row;
                            bestCol = col;
                        }
                        position++;

                    }

                }
                // diagonal down.
                set = 1; // Restarting all the variables.
                direction = "diagonalDown";
                line = row;
                position = col;
                while (direction == "diagonalDown" && line < rows && position < cols)
                {
                    position++;
                    line++;
                    while (position < rows && line < cols && matrix[row, col] == matrix[line, position])
                    {
                        set++;
                        if (set > longestSet)
                        {
                            longestSet = set;
                            bestDirection = direction;
                            bestRow = row;
                            bestCol = col;
                        }
                        position++;
                        line++;
                    }
                }
                // diagonal up.
                set = 1; // Restarting all the variables.
                direction = "diagonalUp";
                line = row;
                position = col;
                while (direction == "diagonalUp" && position >= 0 && line >= 0)
                {
                    position--;
                    line--;
                    while (position >= 0 && line >= 0 && matrix[row, col] == matrix[line, position])
                    {
                        set++;
                        if (set > longestSet)
                        {
                            longestSet = set;
                            bestDirection = direction;
                            bestRow = row;
                            bestCol = col;
                        }
                        position--;
                        line--;
                    }
                }
                // vertical.
                set = 1; // Restarting all the variables.
                direction = "vertical";
                line = row;
                position = col;
                while (direction == "vertical" && line < rows)
                {
                    
                    line++;
                    while (line < rows && matrix[row, col] == matrix[line, position])
                    {
                        set++;
                        if (set > longestSet)
                        {
                            longestSet = set;
                            bestDirection = direction;
                            bestRow = row;
                            bestCol = col;
                        }
                        
                        line++;
                    }
                }
            }
        }

        // Printing the result.
        PrintingResult(matrix, bestRow, bestCol, bestDirection, longestSet);
    }

    
}

