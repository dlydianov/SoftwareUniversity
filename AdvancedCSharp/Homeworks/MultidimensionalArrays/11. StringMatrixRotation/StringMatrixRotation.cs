
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Xml;

class StringMatrixRotation
{
    static void Main()
    {
        string command = Console.ReadLine();
        List<string> lines = new List<string>();
        Input(lines);
        string[,] matrix = new string[lines.Count, lines.OrderByDescending(x => x.Length).ElementAt(0).Length];
        FillMatrix(lines, matrix);
        Output(command, matrix);
    }

    private static int TakeRotation(string command)
    {
        Regex regex = new Regex(@"\d+");
        int rotation = int.Parse(regex.Match(command).ToString());
        return rotation;
    }

    private static void Input(List<string> lines)
    {
        string line = Console.ReadLine();
        while (line != "END")
        {
            lines.Add(line);
            line = Console.ReadLine();
        }
    }

    private static void Output(string command, string[,] matrix)
    {
        int rotation = TakeRotation(command);
        while (rotation / 90 > 0 && rotation / 9 > 0)
        {
            rotation /= 90;
            if (rotation < 10)
            {
                rotation /= 9;
            }
        }
        switch (rotation)
        {
            case 0:
                CaseZero(matrix);
                break;
            case 1:
                CaseOne(matrix);
                break;
            case 2:
                CaseTwo(matrix);
                break;
            case 3:
                CaseThree(matrix);
                break;
        }
    }

    private static void CaseThree(string[,] matrix)
    {
        for (int row = matrix.GetLength(1) - 1; row >= 0; row--)
        {
            for (int col = 0; col < matrix.GetLength(0); col++)
            {
                Console.Write(matrix[col, row]);
            }
            Console.WriteLine();
        }
    }

    private static void CaseTwo(string[,] matrix)
    {
        for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
        {
            for (int col = matrix.GetLength(1) - 1; col >= 0; col--)
            {
                Console.Write(matrix[row, col]);
            }
            Console.WriteLine();
        }
    }

    private static void CaseOne(string[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(1); row++)
        {
            for (int col = matrix.GetLength(0) - 1; col >= 0; col--)
            {
                Console.Write(matrix[col, row]);
            }
            Console.WriteLine();
        }
    }

    private static void CaseZero(string[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write(matrix[row, col]);
            }
            Console.WriteLine();
        }
    }

    private static void FillMatrix(List<string> lines, string[,] matrix)
    {
        for (int row = 0; row < lines.Count; row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                if (col >= lines[row].Length)
                {
                    matrix[row, col] = " ";
                }
                else
                {
                    matrix[row, col] = lines[row][col].ToString();
                }
            }
        }
    }
}
