
using System;
using System.Text;
using System.Text.RegularExpressions;

class SequencesOfEqualStrings
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] inputAsStrings = input.Split(' ');
        int numberOfWords = inputAsStrings.Length;
        for (int index = 0; index < inputAsStrings.Length; index++)
        {         
            Regex regex = new Regex(inputAsStrings[index]);
            MatchCollection matches = regex.Matches(input);
            foreach (var match in matches)
            {
                Console.Write(match + " ");
                input = input.Remove(input.IndexOf(inputAsStrings[index]), inputAsStrings[index].Length);
              
            }
            inputAsStrings = input.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            index = -1; // I make i -1 because it will increased by 1 when it gets to the brackets of the FOR cycle it will be increased to 0;
            Console.WriteLine();
        }

    }
}

