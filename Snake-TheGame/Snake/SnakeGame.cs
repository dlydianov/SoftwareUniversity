using System.Text;
using System.Text.RegularExpressions;

namespace NewGameSnake
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;

    using global::SnakeGame;
    using System.IO;

    internal class SnakeGame
    {
        private static void Main()
        {
            Menu.ConsoleMenu();

            Console.BufferHeight = Console.WindowHeight;
            ConsoleKeyInfo comand = Console.ReadKey();
            if (comand.Key == ConsoleKey.Spacebar)
            {
                Console.Clear();

                string readHighScore = @"..\..\highscore.txt";
                StreamReader reader = new StreamReader(readHighScore);

                using (reader)
                {
                    string line = reader.ReadLine();
                    Console.SetCursorPosition(35,1);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Highscores:");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine();
                    Console.WriteLine();
                    int count = 1;

                    while (line != null)
                    {
                        Console.WriteLine("{0}. {1}", count, line);
                        line = reader.ReadLine();
                        count++;
                    }
                    Console.WriteLine();
                }
            }


            if (comand.Key == ConsoleKey.Enter)
            {
                Console.Clear();
                Console.SetCursorPosition(35, 10);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Level 1");
                Thread.Sleep(3000);
                Console.Clear();

                bool level = true;
                int levelChangeScore = 200;

                byte right = 0;
                byte left = 1;
                byte down = 2;
                byte up = 3;

                Position[] directions = new Position[]
                                            {
                                                new Position(0, 1), //дясно   
                                                new Position(0, -1), //ляво
                                                new Position(1, 0), //долу
                                                new Position(-1, 0), //горе
                                            };
                int snakeSpeed = 100;
                int direction = right;

                //food location
                Random randomNumberGenerator = new Random();
                Position food = new Position(
                    randomNumberGenerator.Next(0, Console.WindowHeight),
                    randomNumberGenerator.Next(0, Console.WindowWidth));

                //food drawing 
                Console.SetCursorPosition(food.col, food.row);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("@");

                Queue<Position> snakeElements = new Queue<Position>();

                //snake begining
                for (int i = 0; i <= 5; i++)
                {
                    snakeElements.Enqueue(new Position(0, i));
                }

                while (level)
                {
                    //moving the snake without pressing a button
                    if (Console.KeyAvailable)
                    {
                        ConsoleKeyInfo userInput = Console.ReadKey();

                        //user direction
                        if (userInput.Key == ConsoleKey.RightArrow)
                        {
                            if (direction != left)
                            {
                                direction = right;
                            }
                        }
                        if (userInput.Key == ConsoleKey.LeftArrow)
                        {
                            if (direction != right)
                            {
                                direction = left;
                            }
                        }
                        if (userInput.Key == ConsoleKey.DownArrow)
                        {
                            if (direction != up)
                            {
                                direction = down;
                            }
                        }
                        if (userInput.Key == ConsoleKey.UpArrow)
                        {
                            if (direction != down)
                            {
                                direction = up;
                            }
                        }

                    }

                    Position snakeHead = Enumerable.Last(snakeElements);
                    Position nextDirection = directions[direction];
                    Position snakeNewHead = new Position(
                        snakeHead.row + nextDirection.row,
                        snakeHead.col + nextDirection.col);

                    //game over
                    if (snakeNewHead.row < 0 || snakeNewHead.col < 0 || snakeNewHead.row >= Console.WindowHeight
                        || snakeNewHead.col >= Console.WindowWidth || snakeElements.Contains(snakeNewHead))
                    {
                        Console.Clear();
                        Console.SetCursorPosition(35, 10);
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine(@"Game Over!
                               Your points are: {0}", (snakeElements.Count - 6) * 100);
                        Console.WriteLine();
                        // Highscore Method / read and print from highscore.txt
                        int currentScore = (snakeElements.Count - 6) * 100; // scores for level 1
                        HighScore(currentScore);


                        return;
                    }

                    //element adding for snake movement
                    snakeElements.Enqueue(snakeNewHead);
                    Console.SetCursorPosition(snakeNewHead.col, snakeNewHead.row);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("*");

                    //food crossing
                    if (snakeNewHead.col == food.col && snakeNewHead.row == food.row)
                    {
                        do
                        {
                            food = new Position(
                                randomNumberGenerator.Next(0, Console.WindowHeight),
                                randomNumberGenerator.Next(0, Console.WindowWidth));
                        }
                        while (snakeElements.Contains(food));
                        Console.SetCursorPosition(food.col, food.row);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("@");
                        snakeSpeed -= 4;
                    }
                    else
                    {
                        Position lastElement = snakeElements.Dequeue();
                        Console.SetCursorPosition(lastElement.col, lastElement.row);
                        Console.Write(" ");
                    }

                    //slowdown the program process
                    Thread.Sleep(snakeSpeed);

                    if ((snakeElements.Count - 6) * 100 == levelChangeScore)
                    {
                        level = false;
                    }
                }

                //level 2

                Console.Clear();
                Console.SetCursorPosition(35, 10);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Level 2");
                Thread.Sleep(4000);
                Console.Clear();

                right = 0;
                left = 1;
                down = 2;
                up = 3;

                directions = new Position[]
                                 {
                                     new Position(0, 1), //дясно   
                                     new Position(0, -1), //ляво
                                     new Position(1, 0), //долу
                                     new Position(-1, 0), //горе
                                 };
                snakeSpeed = 100;
                direction = right;

                //Obstacle drawing
                var obstacles = new List<Position>();

                for (int i = 0; i < Console.WindowWidth - 20; i++)
                {
                    obstacles.Add(new Position(6, i));
                    obstacles.Add(new Position(12, 20 + i));
                    obstacles.Add(new Position(18, i));
                }

                foreach (Position obstacle in obstacles)
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.SetCursorPosition(obstacle.col, obstacle.row);
                    Console.Write("#");
                }

                //food location
                randomNumberGenerator = new Random();
                do
                {
                    food = new Position(
                        randomNumberGenerator.Next(0, Console.WindowHeight),
                        randomNumberGenerator.Next(0, Console.WindowWidth));
                }
                while (snakeElements.Contains(food) || obstacles.Contains(food));

                //food drawing 
                Console.SetCursorPosition(food.col, food.row);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("@");

                snakeElements = new Queue<Position>();

                //snake begining
                for (int i = 0; i <= 5; i++)
                {
                    snakeElements.Enqueue(new Position(0, i));
                }

                while (true)
                {
                    //moving the snake without pressing a button
                    if (Console.KeyAvailable)
                    {
                        ConsoleKeyInfo userInput = Console.ReadKey();

                        //user direction
                        if (userInput.Key == ConsoleKey.RightArrow)
                        {
                            if (direction != left)
                            {
                                direction = right;
                            }
                        }
                        if (userInput.Key == ConsoleKey.LeftArrow)
                        {
                            if (direction != right)
                            {
                                direction = left;
                            }
                        }
                        if (userInput.Key == ConsoleKey.DownArrow)
                        {
                            if (direction != up)
                            {
                                direction = down;
                            }
                        }
                        if (userInput.Key == ConsoleKey.UpArrow)
                        {
                            if (direction != down)
                            {
                                direction = up;
                            }
                        }
                    }

                    Position snakeHead = Enumerable.Last(snakeElements);
                    Position nextDirection = directions[direction];
                    Position snakeNewHead = new Position(
                        snakeHead.row + nextDirection.row,
                        snakeHead.col + nextDirection.col);

                    //game over
                    if (snakeNewHead.row < 0 || snakeNewHead.col < 0 || snakeNewHead.row >= Console.WindowHeight
                        || snakeNewHead.col >= Console.WindowWidth || snakeElements.Contains(snakeNewHead)
                        || obstacles.Contains(snakeNewHead))
                    {

                        Console.Clear();
                        Console.SetCursorPosition(35, 10);
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine(@"Game Over!
                              Your points are: {0}", ((snakeElements.Count - 6) * 100)+levelChangeScore);
                        Console.WriteLine();
                        // Highscore Method / read and print from highscore.txt
                        int currentScore = ((snakeElements.Count - 6) * 100) + 200; // score for level 2
                        HighScore(currentScore);

                        return;
                    }

                    //element adding for snake movement
                    snakeElements.Enqueue(snakeNewHead);
                    Console.SetCursorPosition(snakeNewHead.col, snakeNewHead.row);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("*");

                    //food crossing
                    if (snakeNewHead.col == food.col && snakeNewHead.row == food.row)
                    {
                        do
                        {
                            food = new Position(
                                randomNumberGenerator.Next(0, Console.WindowHeight),
                                randomNumberGenerator.Next(0, Console.WindowWidth));
                        }
                        while (snakeElements.Contains(food) || obstacles.Contains(food));
                        Console.SetCursorPosition(food.col, food.row);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("@");
                        snakeSpeed -= 4;
                    }
                    else
                    {
                        Position lastElement = snakeElements.Dequeue();
                        Console.SetCursorPosition(lastElement.col, lastElement.row);
                        Console.Write(" ");
                    }

                    //slowdown the program process
                    Thread.Sleep(snakeSpeed);
                }
            }
        }

        private static void HighScore(int currentScore)
        {

            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();


            Dictionary<string, int> scoreBoard = new Dictionary<string, int>();

            MatchCollection matches;
            var rgx = new Regex(@"(\w+\s*\w*\s*\w*)\s-\s(\d+)");

            using (StreamReader reader = new StreamReader(@"..\..\highscore.txt"))
            {


                string line = reader.ReadLine();


                while (line != null)
                {
                    matches = rgx.Matches(line);
                    foreach (Match match in matches)
                    {
                        scoreBoard.Add(match.Groups[1].ToString(), int.Parse(match.Groups[2].Value));
                        line = reader.ReadLine();
                    }
                }
            }
            name += " - " + currentScore;
            matches = rgx.Matches(name);

            foreach (Match match in matches)
            {
                scoreBoard.Add(match.Groups[1].ToString(), int.Parse(match.Groups[2].Value));
            }
            using (StreamWriter writer = new StreamWriter(@"..\..\highscore.txt"))
            {
                foreach (KeyValuePair<string, int> kvp in scoreBoard.OrderByDescending(p => p.Value))
                {
                    writer.WriteLine("{0} - {1}", kvp.Key, kvp.Value);
                }
            }
        }


        //кординати на конзолата
        private struct Position
        {
            public int row;

            public int col;

            public Position(int row, int col)
            {
                this.row = row;
                this.col = col;
            }
        }

    }
}