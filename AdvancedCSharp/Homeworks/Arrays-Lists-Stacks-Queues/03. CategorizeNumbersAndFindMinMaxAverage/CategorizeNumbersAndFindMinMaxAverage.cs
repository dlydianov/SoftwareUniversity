using System;
using System.Collections.Generic;
using System.Linq;

class CategorizeNumbersAndFindMinMaxAverage
{
    static void GroupingTheNumberInLists(string[] inputNumbers, List<double> integers, List<double> floatingPoint )
    {

        foreach (var inputNumber in inputNumbers)
        {
            double number = double.Parse(inputNumber);
            if (number == Math.Floor(number))
            {
                integers.Add(number);              
            }
            else
            {
                floatingPoint.Add(number);
            }
        }
    }
    private static void PrintingResult(List<double> floatingNumbers, List<double> integers)
    {
        Console.WriteLine("min: {0}, max: {1}, sum: {2}, avg: {3:F2}", floatingNumbers.Min(), floatingNumbers.Max(), floatingNumbers.Sum(), floatingNumbers.Average());
        Console.WriteLine("min: {0}, max: {1}, sum: {2}, avg: {3}", (int)integers.Min(), (int)integers.Max(), (int)integers.Sum(), (int)integers.Average());
    }
    static void Main()
    {
        string[] inputNumbers = Console.ReadLine().Split(' ');
        List<double> floatingNumbers = new List<double>();
        List<double> integers = new List<double>();

        GroupingTheNumberInLists(inputNumbers, integers, floatingNumbers);
        PrintingResult(floatingNumbers, integers);
    }

   
}

