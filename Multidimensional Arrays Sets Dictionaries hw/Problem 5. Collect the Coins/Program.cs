using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5.Collect_the_Coins
{
    class Program
    {
        static void Main()
        {
            string[][] inputLines = new string[4][];
            inputLines[0] = ToString(Console.ReadLine());
            inputLines[1] = ToString(Console.ReadLine());
            inputLines[2] = ToString(Console.ReadLine());
            inputLines[3] = ToString(Console.ReadLine());
            
        }
        static string[] ToString(string word)
        { 
            string[] temp = new string[word.Length];
            for (int i = 0; i < word.Length; i++)
			{
			    temp[i] = word[i].ToString();
			}
            return temp; 
        }
    }
}
