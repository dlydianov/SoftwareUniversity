using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_6.Palindromes
{
    class Program
    {
        static void Main()
        {
            string[] words = Console.ReadLine().Split(new[] { ",", ", ", ".", "?", "!", " "},StringSplitOptions.RemoveEmptyEntries).ToArray();
            string reverse = string.Empty;
            List<string> final = new List<string>();

            for (int i = 0; i < words.Length; i++)
            {
                char[] split = words[i].ToCharArray();

                for (int j = split.Length - 1 ; j >= 0; j--)
                {
                    reverse += split[j];
                }
                reverse.ToString();
                if (words[i] == reverse)
                {
                    final.Add(words[i]);
                }
                reverse = string.Empty;

            }
            final.Sort();
            Console.WriteLine(string.Join(", ", final));

        }
    }
}
