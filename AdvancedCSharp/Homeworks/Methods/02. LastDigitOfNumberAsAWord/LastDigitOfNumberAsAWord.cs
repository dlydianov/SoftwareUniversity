
using System;
using System.Runtime.Remoting.Messaging;

class LastDigitOfNumberAsAWord
{
    static void Main()
    {
        // Write a method that returns the last digit of a given integer as an English word. Test the method with different input values. Ensure you name the method properly.
        int number = int.Parse(Console.ReadLine());
        int lastDigitOfNumber = GetLastDigit(number);
        PrintLastDigitAsAWord(lastDigitOfNumber);
    }

    private static void PrintLastDigitAsAWord(int lastDigitOfNumber)
    {
        switch (lastDigitOfNumber)
        {
            case 0: Console.WriteLine("zero");
                break;
            case 1: Console.WriteLine("one");
                break;
            case 2: Console.WriteLine("two");
                break;
            case 3: Console.WriteLine("three");
                break;
            case 4: Console.WriteLine("four");
                break;
            case 5: Console.WriteLine("five");
                break;
            case 6: Console.WriteLine("six");
                break;
            case 7: Console.WriteLine("seven");
                break;
            case 8: Console.WriteLine("eight");
                break;
            case 9: Console.WriteLine("nine");
                break;
        }
    }

    private static int GetLastDigit(int number)
    {
        int lastDigit = 0;
        if (number > 0)
        {
           lastDigit  = number % 10;
        }
        if (number < 0)
        {
            number = -(number);
            lastDigit = number%10;
        }
        return lastDigit;
        
    }
}

