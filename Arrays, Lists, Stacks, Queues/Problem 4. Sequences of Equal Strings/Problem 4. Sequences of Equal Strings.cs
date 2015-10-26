using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Sequences_of_Equal_Strings
{
    class Program
    {
        static void Main()
        {
            string[] words = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string word = string.Empty;

            if (words.Length == 1)
            {
                Console.WriteLine(words[0]);
            }
            else
            {
                for (int i = 0; i < words.Length - 1; i++)
                {
                    if (words[i] == words[i + 1])
                    {
                        word += words[i] + " ";
                    }
                    else
                    {
                        word += words[i] + Environment.NewLine;
                    }
                    if (i == words.Length - 2)
                    {
                        word += words[words.Length - 1];
                    }
                }
            }
            Console.WriteLine(word);
        }
    }
}
