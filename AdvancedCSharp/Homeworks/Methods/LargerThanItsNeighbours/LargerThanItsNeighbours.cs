
using System;
using System.Linq;

class LargerThanItsNeighbours
{
    static void Main()
    {
        // Write a method that checks if the element at given position in a given array of integers is larger than its two neighbours (when such exist).

        // input
        string[] input = Console.ReadLine().Split(' ');
        int[] numbers = new int[input.Length];
        for (int i = 0; i < input.Length; i++)
        {
            numbers[i] = int.Parse(input[i]);
        }
        // answer
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(IsNumberBiggerThanNeighbours(numbers, i));
        }
    }

    private static bool IsNumberBiggerThanNeighbours(int[] numbers, int i)
    {
        int leftNeighbour;
        int rightNeighbour;
        int currentNumber;
        if (i - 1 >= 0 && i + 1 < numbers.Length)
        {
            leftNeighbour = numbers[i - 1];
            rightNeighbour = numbers[i + 1];
            currentNumber = numbers[i];
            if (currentNumber > leftNeighbour && currentNumber > rightNeighbour)
            {
                return true;
            }  
        }
        else if (i - 1 >= 0)
        {
            leftNeighbour = numbers[i - 1];
            currentNumber = numbers[i];
            if (currentNumber > leftNeighbour)
            {
                return true;
            }
        }
        else
        {
            rightNeighbour = numbers[i + 1];
            currentNumber = numbers[i];
            if (currentNumber > rightNeighbour)
            {
                return true;
            }  
        }
        return false;
    }
}

