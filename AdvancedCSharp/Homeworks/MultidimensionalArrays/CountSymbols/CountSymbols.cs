using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
class CountSymbols
{
    static void Main()
    {
        string text = Console.ReadLine();
       
        SortedSet<char> allCharacters = new SortedSet<char>();
        for (int i = 0; i < text.Length; i++) // adding characters to set
        {
            allCharacters.Add(text[i]);
        }

        foreach (var character in allCharacters) // result
        {
            Console.WriteLine("{0} : {1} time / s", character, text.Count(x => x == character)); // this is LINQ algorithm which counts the count of certain character in a text. 
        }
        
    }
}

