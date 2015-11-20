
using System;
using System.Text.RegularExpressions;

class LettersChangeNumbers
{
    static void Main()
    {
        
        string input = Console.ReadLine();
        string[] stringSequnces = Regex.Split(input, @"\s+");
        double totalSum = 0;
        Regex regex = new Regex(@"\d+");

        for (int i = 0; i < stringSequnces.Length; i++)
        {
            
            double number = double.Parse(regex.Match(stringSequnces[i]).ToString());
            number = CalculationWithTheLetterBefore(number, stringSequnces[i]);
            number = CalculationWithTheLetterAfter(number, stringSequnces[i]);
            totalSum += number;
        }
        Console.WriteLine("{0:F2}",totalSum);

    }

    private static double CalculationWithTheLetterAfter(double number, string stringSequnces)
    {
        if (char.IsUpper(stringSequnces[stringSequnces.Length - 1]))
        {
            byte letterAlphabetPosition = (byte)(stringSequnces[stringSequnces.Length - 1] - 64);
            number -= letterAlphabetPosition;
        }
        else
        {
            byte letterAlphabetPosition = (byte)(stringSequnces[stringSequnces.Length - 1] - 96);
            number += letterAlphabetPosition;
        }
        return number;
    }

    private static double CalculationWithTheLetterBefore(double number, string stringSequnces)
    {
        if (char.IsUpper(stringSequnces[0]))
        {
            byte letterAlphabetPosition = (byte)(stringSequnces[0] - 64);
            number /= letterAlphabetPosition;
        }
        else
        {
            byte letterAlphabetPosition = (byte)(stringSequnces[0] - 96);
            number *= letterAlphabetPosition;
        }
        return number;

    }
}

