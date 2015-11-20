
using System;
using System.Collections.Generic;
using System.Linq;

class PythagoreanNumbers
{
    private static int a;
    private static int b;
    private static int c;
    private static int[] currentNumbers;
    static void Main()
    {
        int countOfNumbers = int.Parse(Console.ReadLine());
        int[] numbers = new int[countOfNumbers];
        
        ReadingTheNumbers(countOfNumbers, numbers);
        HashSet<int[]> numbersUsed = new HashSet<int[]>();
        GeneratingAnswers(numbers, numbersUsed);

    }

    private static void GeneratingAnswers(int[] numbers, HashSet<int[]> numbersUsed)
    {
        int countOfAnswers = 0;
        for (int n1 = 0; n1 < numbers.Length; n1++)
        {
            for (int n2 = 0; n2 < numbers.Length; n2++)
            {             
                for (int n3 = 0; n3 < numbers.Length; n3++)
                {
                    a = Math.Min(numbers[n1], numbers[n2]);
                    b = Math.Max(numbers[n1], numbers[n2]);
                    c = numbers[n3];

                    
                    if (a * a + b * b == c * c)
                    {
                        currentNumbers = new []{ a, b };
                        if (!AnswerHasAlreadyBeenOutputed(numbersUsed, currentNumbers))
                        {
                            Console.WriteLine("{0}*{0} + {1}*{1} = {2}*{2}", a, b, c);
                            numbersUsed.Add(currentNumbers);
                            countOfAnswers++;

                        }
                        
                       
                    }
                }
            }
        }
        if (countOfAnswers == 0)
        {
            Console.WriteLine("No");
        }
    }

    private static bool AnswerHasAlreadyBeenOutputed(HashSet<int[]> answers, int[] answer)
    {
        foreach (var item in answers)
        {
            if (item[0] == answer[0] && item[1] == answer[1])
            {
                return true;
            }
            
        }
        return false;
    }

    private static void ReadingTheNumbers(int countOfNumbers, int[] numbers)
    {
        for (int i = 0; i < countOfNumbers; i++)
        {
            int number = int.Parse(Console.ReadLine());
            numbers[i] = number;
        }

    }
}

