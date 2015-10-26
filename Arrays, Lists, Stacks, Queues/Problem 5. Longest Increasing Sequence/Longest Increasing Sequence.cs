using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5.Longest_Increasing_Sequence
{
    class Program
    {
        static void Main()
        {
            int[] lSubsents = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int len = 1;
            int startIndex = 0;
            int maxLen = 0;
            for (int i = 1; i < lSubsents.Length; i++)
            {
                Console.Write("{0} ", lSubsents[i - 1]);

                if (i == lSubsents.Length - 1 && lSubsents[i] > lSubsents[i - 1])
                {

                    Console.Write("{0} ", lSubsents[lSubsents.Length - 1]);
                }
                else if (i == lSubsents.Length - 1 && lSubsents[i] < lSubsents[i - 1])
                {
                    Console.WriteLine();
                    Console.Write("{0} ", lSubsents[lSubsents.Length - 1]);

                }
                else if (lSubsents[i] == lSubsents[i - 1])
                {
                    Console.WriteLine();
                }

                if (lSubsents[i] < lSubsents[i - 1])
                {
                    Console.WriteLine();
                }

                if (lSubsents[i] > lSubsents[i - 1])
                {
                    len++;
                    if (maxLen < len)
                    {
                        maxLen = len;
                    }
                }
                else if (lSubsents[i] < lSubsents[i - 1])
                {
                    if (maxLen > len || maxLen == 0)
                    {
                        startIndex = i;
                    }

                    len = 1;
                }

            }
            Console.WriteLine();
            if (len == 1)
            {
                Console.WriteLine(lSubsents[0]);
            }
            else
            {
                Console.Write("Longest: ");
                for (int i = startIndex; i < (maxLen + startIndex); i++)
                {
                    Console.Write("{0} ", lSubsents[i]);
                }
            }
            Console.WriteLine();

        }
    }
}
