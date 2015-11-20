
using System;

class BiggerNumber
{
    static void Main()
    {
        // Write a method GetMax() with two parameters that returns the larger of two integers. Write a program that reads 2 integers from the console and prints the largest of them using the method GetMax().

        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());

        GetTheBiggerNumber(firstNumber, secondNumber);
    }

    private static void GetTheBiggerNumber(int firstNumber, int secondNumber)
    {
        int biggerNumber = Math.Max(firstNumber, secondNumber);
        Console.WriteLine(biggerNumber);
    }
}

