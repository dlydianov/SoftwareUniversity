using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.Sort_Array_of_Numbers_Using_Selection_Sort
{
    class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            for (int j = 0; j < numbers.Length; j++)
            {
                int temp = j;
                for (int i = j + 1; i < numbers.Length; i++)
                {
                    if (numbers[i] < numbers[temp])
                    {
                        temp = i;
                    }
                }
                if (temp != j)
                {
                    int v = numbers[temp];
                    numbers[temp] = numbers[j];
                    numbers[j] = v;
                }
            }
            Console.WriteLine(string.Join(" ", numbers));

        }
    }
}
