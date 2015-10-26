using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.Count_Substring_Occurrences
{
    namespace System.Text.RegularExpressions.Regex
    {
        class Program
        {
            static void Main()
            {
                string sentence = Console.ReadLine().ToLower();
                string givenWord = Console.ReadLine().ToLower();
                int match = sentence.IndexOf(givenWord);
                int count = 0;

                for (int i = 0; i < sentence.Length; i++)
                {
                    if (match >= 0)
                    {
                        string taken = sentence.Substring(match, givenWord.Length);
                        if (taken == givenWord)
                        {
                            count++;
                            match = sentence.IndexOf(givenWord, match + 1);
                        }
                    }
                }
                Console.WriteLine(count);
                    
            }
        }
    }
}
