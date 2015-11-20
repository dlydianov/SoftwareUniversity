
using System;


class CalculationMethods
{
    public static int MinimumNumber(int[] numbers)
    {
        int minimumNumber = Int32.MaxValue;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] < minimumNumber)
            {
                minimumNumber = numbers[i];
            }
        }
        return minimumNumber;
    }

    public static int MaximumNumber(int[] numbers)
    {
        int maximumNumber = int.MinValue;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > maximumNumber)
            {
                maximumNumber = numbers[i];
            }
        }
        return maximumNumber;
    }
    public static double Average(int[] numbers)
    {
        double average = 0;
        int sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];

        }
        average = sum / numbers.Length;
        return average;
    }
    public static int Sum(int[] numbers)
    {
        int sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];

        }
        return sum;
    }
    public static long Product(int[] numbers)
    {
        long product = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            product *= numbers[i];

        }
        return product;
    }
}


