using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _09.TerroristWin
{
    class TerroristWin
    {
        static void Main()
        {
            string input = Console.ReadLine();
            Regex regex = new Regex(@"\|.*?\|");
          
            MatchCollection matches = regex.Matches(input);
            foreach (var match in matches)
            {
                string bomb = match.ToString();
                int sum = bomb.ToCharArray().Where(x => x != 124).Sum(x => x);
                int bombPower = sum%10;             
                int impact = bomb.Length + (bombPower*2);             
                input = CheckingConditions(input, impact, bomb, bombPower);              

            }
            Console.WriteLine(input);
            
        }

        private static string CheckingConditions(string input, int impact, string bomb, int bombPower)
        {
            int indexOfBomb = input.IndexOf(bomb);
            int startingPointOfImpact = indexOfBomb - bombPower;
            int lastIndexOfBomb = indexOfBomb + bomb.Length;
            int endPointOfImpact = lastIndexOfBomb + bombPower;

            if (startingPointOfImpact >= 0 && endPointOfImpact < input.Length)
            {
                string charactersToBeReplaced = input.Substring(startingPointOfImpact, impact);
                input = input.Replace(charactersToBeReplaced, new string('.', impact));
            }
            else if (startingPointOfImpact < 0 && endPointOfImpact >= input.Length)
            {

                input = input.Replace(input, new string('.', input.Length));
            }
            else if (startingPointOfImpact < 0)
            {
                string charactersToBeReplaced = input.Substring(0, endPointOfImpact);
                input = input.Replace(charactersToBeReplaced, new string('.', endPointOfImpact));
            } 
            
            else if (endPointOfImpact >= input.Length)
            {
                string charactersToBeReplaced = input.Substring(startingPointOfImpact, input.Length - startingPointOfImpact);
                input = input.Replace(charactersToBeReplaced, new string('.', input.Length - startingPointOfImpact));
            }
            if (bomb == string.Empty)
            {
                input = input.Replace("||", new string('.', 2));
            }
            return input;
        }
    }
}
