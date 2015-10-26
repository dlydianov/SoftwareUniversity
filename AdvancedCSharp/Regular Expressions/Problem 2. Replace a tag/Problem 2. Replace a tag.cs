using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Problem_2.Replace_a_tag
{
    class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();
            //Regex regex = new Regex(@"<\s*a\s+href\s*=\W?(\b.*\b)\W?>(\b.*\b)</a>");
            Regex regex = new Regex(@"<\s?a\s+href=\W?(\b.+\b[.][A-z]+)\W?>(\b.+\b)</a>");

            text = regex.Replace(text, @"[URL href=$1]$2[/URL]");
            Console.WriteLine(text);
        }
    }
}
