using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Problem_3.Extract_Emails
{
    class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();
            string pattern = @"[A-z][A-z0-9.-_]+@[A-z][A-z0-9._-]*[.][A-z]*";

            Regex regex = new Regex(pattern);
            MatchCollection matches = Regex.Matches(text, pattern);

            foreach (Match match in matches)
            {
                Console.WriteLine("{0}", match.Groups[0]);
            }

        }
    }
}
