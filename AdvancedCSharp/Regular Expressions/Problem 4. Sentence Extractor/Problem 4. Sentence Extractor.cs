using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Problem_4.Sentence_Extractor
{
    class Program
    {
        static void Main()
        {
            string keyword = Console.ReadLine();
            string text = Console.ReadLine();

            string pattern = String.Format(@"([^!.?]*\b{0}\b[^!.?]*[!.?])", keyword);
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(text);
            foreach (Match match in matches)
            {
                Console.WriteLine(match);
            }
            //string keyword = Console.ReadLine();
            //string text = Console.ReadLine();
            //string pattern = @"([A-Z].+)\s" + keyword + @"\s(.+[.])";

            //Regex regex = new Regex(pattern);
            //MatchCollection matches = Regex.Matches(text, pattern);

            //foreach (Match match in matches)
            //{
            //    Console.WriteLine("{0}", match.Groups[0]);
            //}

        }
    }
}
