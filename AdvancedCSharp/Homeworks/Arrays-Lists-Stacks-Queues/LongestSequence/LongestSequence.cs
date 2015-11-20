

using System;
using System.Text;

class LongestSequence
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');
        int currentIndex = 0;
        int sequenceCount = 0;
        int longestSequenceCount = 0;
        string longestSequence = string.Empty;
        int currentNumber = int.Parse(input[currentIndex]);

        while (currentIndex < input.Length)
        {
            StringBuilder sequence = new StringBuilder();         
            int lastNumber = int.MinValue;

            while (currentNumber > lastNumber)
            {
                sequence.Append(input[currentIndex] + " ");
                lastNumber = currentNumber;
                sequenceCount++;
                if (sequenceCount > longestSequenceCount)
                {
                    longestSequence = sequence.ToString();
                    longestSequenceCount = sequenceCount;
                }
                currentIndex++;
                if (currentIndex == input.Length)
                {
                    break;
                }
                currentNumber = int.Parse(input[currentIndex]);

            }
            Console.WriteLine(sequence.ToString());
            sequenceCount = 0;


        }
        Console.WriteLine("Longest: {0}", longestSequence);
    }
}

