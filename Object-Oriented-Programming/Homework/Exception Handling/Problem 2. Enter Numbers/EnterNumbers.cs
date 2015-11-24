using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.Enter_Numbers
{
    class EnterNumbers
    {
        static void Main()
        {
            int a = 1;
            int b = 100;
            ReadNumber(a, b);
        }

        public static void ReadNumber(int start, int end)
        {
            try
            {
                int input = int.Parse(Console.ReadLine());
                int temp = 0;
                for (int i = 0; i < 10; i++)
                {
                    while (input < start || input > end)
                    {
                        Console.WriteLine("Please enter numbers between {0} and {1}", start, end);
                        input = int.Parse(Console.ReadLine());
                    }
                    while (input <= temp)
                    {
                        Console.WriteLine("Please enter a bigger number.");
                        input = int.Parse(Console.ReadLine());
                    }
                    temp = input;
                    input = int.Parse(Console.ReadLine());
                }
                
            }
            catch (Exception)
            {
                throw new ArgumentException("This is not a number.");
                return 
            }
        }
    }
}
