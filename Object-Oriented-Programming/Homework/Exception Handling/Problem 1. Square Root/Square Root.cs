using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.Square_Root
{
    class SquareRoot
    {
        static void Main()
        {
            try
            {
                int n = int.Parse(Console.ReadLine());
                if (n < 0)
                {
                    throw new ArgumentException("Number cannot be negative.");
                }
                double a = Math.Sqrt(n);
                Console.WriteLine("{0} square root is: {1}",n, a);
            }
            catch (Exception)
            {
                throw new ArgumentException("Invalid number.");
            }
            finally
            {
                Console.WriteLine("GoodBye");
            }
        }
    }
}
