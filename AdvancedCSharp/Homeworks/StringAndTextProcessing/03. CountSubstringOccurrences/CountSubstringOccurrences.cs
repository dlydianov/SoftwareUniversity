using System;


class CountSubstringOccurrences
{
    static void Main()
    {
        //  Write a program to find how many times a given string appears in a given text as substring. The text is given at the first input line. The search string is given at the second input line. The output is an integer number. Please ignore the character casing. Overlapping between occurrences is allowed. 

        string text = Console.ReadLine();
        string substring = Console.ReadLine();
        int count = 0;

        for (int i = 0; i <= text.Length - substring.Length; i++)
        {
            
            if(string.Compare(text.Substring(i, substring.Length), substring, true) == 0)
            {
                count++;
            }
        }

        Console.WriteLine(count);
    }
}

