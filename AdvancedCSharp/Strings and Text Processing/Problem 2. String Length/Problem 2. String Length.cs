using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.String_Length
{
    class Program
    {
        static void Main()
        {
            char[] sentence = Console.ReadLine().ToArray();

            if (sentence.Length < 20)
            {
                for (int i = 0; i < sentence.GetLength(0); i++)
                {
                    Console.Write(sentence[i]);
                }
                Console.WriteLine(new string('*', 20 - sentence.Length));
            }
            else
            {
                for (int i = 0; i <= 20; i++)
                {
                    Console.Write(sentence[i]);
                }
                Console.WriteLine();
            }
        }
    }
}
