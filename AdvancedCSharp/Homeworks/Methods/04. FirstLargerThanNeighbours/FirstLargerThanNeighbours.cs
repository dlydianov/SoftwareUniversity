
using System;

class FirstLargerThanNeighbours
{
    static void Main()
    {
        // Write a method that returns the index of the first element in array that is larger than its neighbours, or -1 if there's no such element.
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
            if (GetTheFirstNumberBiggerThanNeighbours(numbers, i))
            {
                Console.WriteLine(i);
                return;
            }
        }
        Console.WriteLine(-1);

    }
    private static bool GetTheFirstNumberBiggerThanNeighbours(int[] numbers, int i)
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
