
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

class GenericArraySort
{
    static void Main()
    {
        int[] numbers =  {15, 15 ,51,5154, 1, 5, 23, 90};
        List<string> strings = new List<string>{ "day", "monday", "a"}; 
        List<List<int>> integers = new List<List<int>>();

        for (int i = 0; i < numbers.Length; i++)
        {
            List<int> n = new List<int>();
            for (int j = 0; j < numbers.Length; j++)
            {
                n.Add(numbers[j]);
            }
            integers.Add(n);
        }

        Output(strings, numbers, integers);
      
    }

    private static void Output(List<string> strings, int[] numbers, List<List<int>> integers)
    {
        foreach (var list in integers)
        {
            Sort(list);
            Console.WriteLine(string.Join(",", list));
        }

        Sort(numbers);
        Sort(strings);
        Console.WriteLine(string.Join(",", numbers));
        Console.WriteLine(string.Join(",", strings));
    }

    private static void Sort<T>(IList<T> numbers) where  T : IComparable
    {
        
        for (int i = 0; i < numbers.Count; i++)
        {
            var currentCharacter = numbers[i];
            int indexOfComparer = i - 1;
            int indexOfCurrentNumber = i;
                      
            while (indexOfComparer >= 0 && currentCharacter.CompareTo(numbers[indexOfComparer]) < 0)
            {
                SwapingNumbers(currentCharacter, numbers, indexOfCurrentNumber, indexOfComparer);                       
                indexOfComparer--;
                indexOfCurrentNumber--;                             
            }
        }
        
    }

    private static void SwapingNumbers<T>(T currentCharacter, IList<T> numbers, int indexOfCurrentNumber, int indexOfComparer)
    {
        var container = currentCharacter;
        numbers[indexOfCurrentNumber] = numbers[indexOfComparer];
        numbers[indexOfComparer] = container;  
    }
}

