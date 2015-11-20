using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;



class ReplaceHTMLTag
{
    static void Main()
    {
        // Write a program that replaces in a HTML document given as string all the tags <a href=…>…</a> with corresponding tags [URL href=…]…[/URL]. Print the result on the console. 

        string input = Console.ReadLine();
        string pattern = @"<a.*href=(.*|\n)>(.*|\n)</a>";
        string replace = @"[URL href=$1]$2[/URL]";
        Regex regex = new Regex(pattern);
        input = regex.Replace(input, replace);
        Console.WriteLine(input);

    }
}

