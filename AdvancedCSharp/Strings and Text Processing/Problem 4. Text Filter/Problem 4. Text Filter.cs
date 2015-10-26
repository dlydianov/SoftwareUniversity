using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Text_Filter
{
    class Program
    {
        static void Main()
        {
            string[] banned = Console.ReadLine().Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string text = Console.ReadLine();
            List<string> bannedWords = new List<string>();
            string taken = string.Empty;
            string wordStar = string.Empty;
            string replaced = string.Empty;

            for (int i = 0; i < banned.Length; i++)
            {
                wordStar = new string('*', banned[i].Length);
                bannedWords.Add(wordStar);

            }
            StringBuilder ready = new StringBuilder();
            ready.Insert(0, text);
            for (int i = 0; i < banned.Length; i++)
            {
                ready.Replace(banned[i], bannedWords[i]);
            }
            ready.ToString();
            Console.WriteLine(ready);
        }
    }
}
