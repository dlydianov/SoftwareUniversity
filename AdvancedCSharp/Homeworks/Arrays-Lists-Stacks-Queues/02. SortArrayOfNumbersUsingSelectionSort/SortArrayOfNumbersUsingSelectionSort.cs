using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SortArrayOfNumbersUsingSelectionSort
{
    private static void SelectonSort(List<int> integers, List<int> sortedIntegers)
    {
        for (int currentIndex = 0; currentIndex < integers.Count; currentIndex++)
        {
            sortedIntegers.Add(integers[currentIndex]);
            
            for (int index = 0; index < sortedIntegers.Count; index++)
            {
                if (sortedIntegers[currentIndex] < sortedIntegers[index])
                {
                    int biggerNumberContainer = sortedIntegers[index];
                    sortedIntegers[index] = sortedIntegers[currentIndex];
                    sortedIntegers[currentIndex] = biggerNumberContainer;
                }
            }
        }
    }

    static void ListFilling(string[] inputNumber, List<int> integers)
    {

        foreach (var number in inputNumber)
        {
            int integer = int.Parse(number);
            integers.Add(integer);
        }
    }
    static void Main()
    {
        string[] inputNumbers = Console.ReadLine().Split(' ');
        List<int> integers = new List<int>();
        List<int> sortedIntegers = new List<int>();

        ListFilling(inputNumbers, integers);
        SelectonSort(integers, sortedIntegers);
        Console.WriteLine("{0}", string.Join(", ", sortedIntegers));
    }
}

