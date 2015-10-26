using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Problem_1.Series_of_Letters
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            Regex regex = new Regex(@"(.)\1+");
            input = regex.Replace(input, "$1");
            Console.WriteLine(input);
        }
    }
}
