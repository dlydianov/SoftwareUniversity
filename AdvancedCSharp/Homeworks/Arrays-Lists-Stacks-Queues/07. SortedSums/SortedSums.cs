using System;
using System.Collections.Generic;
using System.Linq;

class SortedSums
{
    static List<List<int>> allAnswers = new List<List<int>>();
    static void Main()
    {
        // input
        int number = int.Parse(Console.ReadLine());
        string[] input = Console.ReadLine().Split(' ');

        // filtering
        List<int> uniqueIntegers = new List<int>();
        FillingTheUniqueIntegers(uniqueIntegers, input);

        // all combinations
        IteratingAllSubsetsToFindTheAnswers(uniqueIntegers, number);

        // output
        PrintingTheOutput(number);
       
    }



    private static void FilteringTheUniqueNumber(List<int> uniqueIntegers, int currentNumber)
    {
        if (uniqueIntegers.Contains(currentNumber))
        {
            return;
        }
        uniqueIntegers.Add(currentNumber);

    }
    private static void FillingTheUniqueIntegers(List<int> uniqueIntegers, string[] input)
    {
        for (int i = 0; i < input.Length; i++)
        {
            int currentNumber = int.Parse(input[i]);
            FilteringTheUniqueNumber(uniqueIntegers, currentNumber);
        }
    }


    private static void IteratingAllSubsetsToFindTheAnswers(List<int> uniqueIntegers, int number)
    {
        // to take all possible subsets using the bits of every number until the maxSubset number to show the different combinations and save them in array of bools where a bool is true when the bit is 1. 

        int maxSubsets = (int)Math.Pow(2, uniqueIntegers.Count);
        List<int> numbersUsed;
        for (int i = 0; i < maxSubsets; i++)
        {
            int result = 0;
            numbersUsed = new List<int>();
            for (int j = 0; j < uniqueIntegers.Count; j++)
            {
                if (((i >> j) & 1) == 1)
                {
                    //finding the combination whose sum is == number
                    result += uniqueIntegers[j];
                    numbersUsed.Add(uniqueIntegers[j]);
                }
            }
            FindingAnswers(uniqueIntegers, result, number, numbersUsed);
        }
    }


    static void FindingAnswers(List<int> uniqueIntegers, int result, int number, List<int> numberUsed)
    {
        
        if (result == number)
        {
            numberUsed.Sort();
            allAnswers.Add(numberUsed);
        }
       
    }
    private static void PrintingTheOutput(int number)
    {
        // I am ordering the list by the count of the number inside and after that by the first number. I have already sorted the inner lists when I was adding them to allAnswers.
        var sortedAnswers = allAnswers.OrderBy(list => list.Count).ThenBy(list => list[0]);
        if (allAnswers.Count == 0)
        {
            Console.WriteLine("No");
            return;
        }
        foreach (var answer in sortedAnswers)
        {
            Console.WriteLine("{0} = {1}", string.Join(" + ", answer), number);
        }

    }

}

