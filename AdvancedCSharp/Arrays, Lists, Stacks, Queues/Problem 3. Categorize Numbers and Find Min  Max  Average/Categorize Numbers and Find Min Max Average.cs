using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.Categorize_Numbers_and_Find_Min__Max__Average
{
    class Program
    {
        static void Main()
        {
            double[] numbers = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
            List<double> round = new List<double>();
            List<double> notround = new List<double>();

            for (int i = 0; i < numbers.Length; i++)
            {
                bool temp = numbers[i] % 1 == 0;
                if (temp)
                {
                    round.Add(numbers[i]);
                }
                else
                {
                    notround.Add(numbers[i]);
                }
            }

            Console.WriteLine("[{0}] -> Min: {1:f2} Max: {2:f2} Sum: {3:f2} Avg: {4:f2}", string.Join(", ", notround), notround.Min(), notround.Max(), notround.Sum(), notround.Average());
            Console.WriteLine("[{0}] -> Min: {1:f2} Max: {2:f2} Sum: {3:f2} Avg: {4:f2}", string.Join(", ", round), round.Min(), round.Max(), round.Sum(), round.Average());
        }
    }
}
