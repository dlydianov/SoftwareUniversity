using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace __Problem_7.Letters_change_Numbers
{
    class Program
    {
        static void Main()
        {
            string[] strings = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            List<char> letters = new List<char>();
            string numbers = string.Empty;
            double totalSum = 0;
            double total = 0;
            int index = 0;

            for (int i = 0; i < strings.Length; i++)
            {
                char[] current = strings[i].ToCharArray();

                for (int j = 0; j < current.Length; j++)
                {
                    if (Char.IsNumber(current[j]))
                    {
                        int n = Convert.ToInt32(new string(current[j], 1));
                        numbers += n;
                    }
                    else
                    {
                        letters.Add(current[j]);
                    }
                }
                double intNumbers = int.Parse(numbers);
                for (int m = 0; m < letters.Count; m++)
                {

                    if (char.IsLower(letters[m]))
                    {
                        if (current[m] == current[0])
                        {
                            index = (letters[0] < 97 ? letters[0] - 64 : letters[0] - 96);
                            total = intNumbers * index;
                        }
                        else
                        {
                            index = (letters[1] < 97 ? letters[1] - 64 : letters[1] - 96);
                            total += index;
                        }
                    }
                    else
                    {
                        if (current[m] == letters[0])
                        {
                            index = (letters[0] < 97 ? letters[0] - 64 : letters[0] - 96);
                            total = intNumbers / index;
                        }
                        else
                        {
                            index = (letters[1] < 97 ? letters[1] - 64 : letters[1] - 96);
                            total -= index;
                        }
                    }
                }
                letters = new List<char>();
                totalSum += total;
                numbers = string.Empty;
            }
            Console.WriteLine("{0:f2}", totalSum);
        }
    }
}
