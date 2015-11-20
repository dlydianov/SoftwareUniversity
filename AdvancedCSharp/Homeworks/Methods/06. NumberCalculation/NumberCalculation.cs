
using System;


class NumberCalculation
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');
        int[] numbers = new int[input.Length];
        for (int i = 0; i < input.Length; i++)
        {
            numbers[i] = int.Parse(input[i]);
        }

        int minNumber = CalculationMethods.MinimumNumber(numbers);
        int maxNumber = CalculationMethods.MaximumNumber(numbers);
        int sum = CalculationMethods.MaximumNumber(numbers);
        double average = CalculationMethods.Average(numbers);
        long product = CalculationMethods.Product(numbers);
        Console.WriteLine("Max: {0}; Min: {1}; Sum: {2}; Average: {3:F2}; Product: {4}", maxNumber, minNumber, sum,
            average, product);


    }
}




