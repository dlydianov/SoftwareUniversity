using System;
using System.Collections.Generic;
using System.Linq;
class ReverseString
{
    static void Main()
    {
        // Write a program that reads a string from the console, reverses it and prints the result back at the console.

        string input = Console.ReadLine();
        string reversedInput = new string(input.Reverse().ToArray());
        Console.WriteLine(reversedInput);
    }
}

