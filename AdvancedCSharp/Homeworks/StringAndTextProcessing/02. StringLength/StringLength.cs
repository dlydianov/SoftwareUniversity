using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
class StringLength
{
    static void Main()
    {
        // Write a program that reads from the console a string of maximum 20 characters. If the length of the string is less than 20, the rest of the characters should be filled with *. Print the resulting string on the console.

        string text = Console.ReadLine();

        string twentyCharacters = text.Length > 20 ? new string(text.Take(20).ToArray()) : text;
        Console.WriteLine(twentyCharacters.PadRight(20, '*'));
    }
}

