using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings_and_Text_Processing
{
    class Program
    {
        static void Main()
        {
            char[] word = Console.ReadLine().ToArray();

            for (int i = word.GetLength(0) - 1; i >= 0; i--)
            {
                Console.Write(word[i]);
            }
            Console.WriteLine();
        }
    }
}
