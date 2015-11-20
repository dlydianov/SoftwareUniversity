using System;
using System.Text.RegularExpressions;

class SeriesOfLetters
{
    static void Main()
    {
        // Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one.
        string text = Console.ReadLine();
        string pattern;
        string replace;
        Regex regexRepl;
        for (int i = 0; i < text.Length; i++)
        {
            pattern = string.Format(@"{0}+", text[i]);
            replace = string.Format(@"{0}", text[i]);
            regexRepl = new Regex(pattern);
            text = regexRepl.Replace(text, replace);
        }
        Console.WriteLine(text);
    }
}