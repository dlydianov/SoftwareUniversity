

using System;
using System.Text;

class ReverseNumber
{
    static void Main()
    {
        double reversed = GetReversedNumber(Console.ReadLine());
        Console.WriteLine(reversed);
    }

    private static double GetReversedNumber(string number)
    {
        StringBuilder reversedNumber = new StringBuilder();
        for (int i = number.Length - 1; i >= 0; i--)
        {
            reversedNumber.Append(number[i]);
        }
        return double.Parse(reversedNumber.ToString());
    }
}

