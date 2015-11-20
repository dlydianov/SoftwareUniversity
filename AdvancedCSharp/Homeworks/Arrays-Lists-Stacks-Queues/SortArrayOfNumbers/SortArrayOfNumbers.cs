using System;
using System.Collections.Generic;
using System.Linq;

class SortArrayOfNumbers
    {
        static void Main()
        {
            // reading the input 

            string[] inputNumbers = Console.ReadLine().Split(' ');           
            List<int> integers = new List<int>();

            // adding the numbers to a list
            foreach (var number in inputNumbers)
            {
                int integer = int.Parse(number);
                integers.Add(integer);
            }

            // sorting the List
            integers.Sort();

            // printing result
            Console.WriteLine("{0}", string.Join(", ", integers));
        }
    }

