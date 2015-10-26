using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.Sort_Array_of_Numbers
{
    class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            bool temp = true;
            while (temp)
            {
                temp = false;
                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    if (numbers[i] > numbers[i+1])
                    {
                        int a = numbers[i];
                        numbers[i] = numbers[i + 1];
                        numbers[i + 1] = a;
                        temp = true;
                    }
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
