using System;

class CollectTheCoins
{
   
    static void Main()
    {
        // Working with multidimensional arrays can be (and should be) fun. Let's make a game out of it.You receive the layout of a board from the console. Assume it will always have 4 rows which you'll get as strings, each on a separate line. Each character in the strings will represent a cell on the board. Note that the strings may be of different length. You are the player and start at the top-left corner (that would be position [0, 0] on the board). On the fifth line of input you'll receive a string with movement commands which tell you where to go next, it will contain only these four characters – '>' (move right), '<' (move left), '^' (move up) and 'v' (move down). You need to keep track of two types of events – collecting coins (represented by the symbol '$', of course) and hitting the walls of the board (when the player tries to move off the board to invalid coordinates). When all moves are over, print the amount of money collected and the number of walls hit. 


        // reading the input's strings
        int rows = 4;
        string[][] boardRows = new string[rows][];
        for (int row = 0; row < rows; row++)
        {
            string input = Console.ReadLine();
            boardRows[row] = new string[input.Length];
            for (int  col = 0;  col < input.Length; col ++)
            {
                boardRows[row][col] = input[col].ToString();
            }
        }

        // getting the commands.
        int line = 0;
        int position = 0;
        int coins = 0;
        int wallsHit = 0;
        char lastCommand = ' '; // counter
        string commands = Console.ReadLine();

        // iterating the jagged array and solving the task by its entity
        for (int command = 0; command < commands.Length; command++)
        {
            if(line < 0 ||  position < 0 || position >= boardRows[line].Length || line >= boardRows.Length ) // getting the wall hits.
            {
                wallsHit++;

                if( lastCommand == '^')
                {
                    line++;
                }
                else if (lastCommand == '<')
                {
                    position++;
                }
                else if (lastCommand == 'V')
                {
                    line--;
                }
                else if (lastCommand == '>')
                {
                    position--;
                }
                continue; // escaping the exception and continuing the code.
            }
            if(boardRows[line][position] == "$") // getting the coins
            {
                coins++;
            }
            if(commands[command] == 'V')
            {
                line++;
            }
            else if(commands[command] == '>')
            {
                position++;
            }
            else if(commands[command] == '^')
            {
                line--;
            }
            else if (commands[command] == '<')
            {
                position--;
            }
            lastCommand = commands[command];
        }
        
        // printing result

        Console.WriteLine("Coins collected: {0}", coins);
        Console.WriteLine("Walls hit: {0}", wallsHit);

    }

   
}

