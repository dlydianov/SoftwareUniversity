
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class SubsetSums
{
    
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        string[] input = Console.ReadLine().Split(' ');
        List<int> uniqueIntegers = new List<int>();
        HashSet<bool[]> allSubsets = new HashSet<bool[]>(); 
        FillingTheUniqueIntegers(uniqueIntegers, input);
        TakingAllSubsetsPossible(allSubsets,uniqueIntegers, number);
        FindingAnswers(allSubsets, uniqueIntegers, number);
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


    private static void TakingAllSubsetsPossible(HashSet<bool[]> allSubsets, List<int> uniqueIntegers, int number)
    {
        int maxSubsets = (int)Math.Pow(2, uniqueIntegers.Count);
        for (int i = 0; i < maxSubsets; i++)
        {
            bool[] subset = new bool[uniqueIntegers.Count];
            for (int j = 0; j < uniqueIntegers.Count; j++)
            {

                if (((i >> j) & 1) == 0)
                {
                    subset[j] = false;
                }
                else
                {
                    subset[j] = true;
                }
            }
            allSubsets.Add(subset);
        }


    }


    private static void FindingAnswers(HashSet<bool[]> allSubsets, List<int> uniqueIntegers, int number)
    {
        List<int> numbersUsed;
        int countOfAnswers = 0;
        foreach (var subset in allSubsets)
        {
            int result = 0;
            numbersUsed = new List<int>();
            for (int i = 0; i < subset.Length; i++)
            {
                if (subset[i])
                {
                    result += uniqueIntegers[i];
                    numbersUsed.Add(uniqueIntegers[i]);
                }
            }
            if (result == number)
            {
                Console.WriteLine(string.Join(" + ", numbersUsed));
                countOfAnswers++;
            }
        }
        if (countOfAnswers == 0)
        {
            Console.WriteLine("No");
        }
    }


    
}




