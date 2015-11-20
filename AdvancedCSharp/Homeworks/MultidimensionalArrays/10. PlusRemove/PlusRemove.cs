using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace _10.PlusRemove
{
    class PlusRemove
    {
        static void Main()
        {          
           
            StringBuilder builder = new StringBuilder();
            string line = Console.ReadLine();
            List<string> input = new List<string>();
            List<bool[]> deletionList = new List<bool[]>();
            while (line != "END")
            {
                input.Add(line);
                deletionList.Add(new bool[line.Length]);
                line = Console.ReadLine();
            }       
            StringBuilder output = new StringBuilder();
            CheckForPlusShape(input, deletionList);
            PlusRemoval(input, deletionList, output);
            Console.WriteLine(output.ToString());
         
        }

        private static void PlusRemoval(List<string> input, List<bool[]> deletionList, StringBuilder output)
        {
            for (int indexOfList = 0; indexOfList < deletionList.Count; indexOfList++)
            {
                for (int indexOfArray = 0; indexOfArray < deletionList[indexOfList].Length; indexOfArray++)
                {
                    if (!deletionList[indexOfList][indexOfArray])
                    {
                        output.Append(input[indexOfList][indexOfArray]);
                    }
                }
                output.AppendLine();
            }
        }

        private static void CheckForPlusShape(List<string> input, List<bool[]> deletionList )
        {
            for (int indexOfList = 0; indexOfList < input.Count; indexOfList++)
            {
                for (int indexOfString = 0; indexOfString < input[indexOfList].Length; indexOfString++)
                {                                    
                    int middleOfPlus = indexOfList + 1;
                    int bottomOfPlus = indexOfList + 2;
                    if(!ThereCanBePlus(input, indexOfString, middleOfPlus, bottomOfPlus))
                    {
                        continue;
                    }
                   
                    string currentCharacter = input[indexOfList][indexOfString].ToString().ToLower();
                    string bottomCharacter = input[bottomOfPlus][indexOfString].ToString().ToLower();               
                    string theThreeCharactersBelowTheCurrentOne = input[middleOfPlus].Substring(indexOfString - 1, 3).ToLower();

                    bool thereIsAPlus = (theThreeCharactersBelowTheCurrentOne.All(character => character.ToString() == currentCharacter) && currentCharacter == bottomCharacter);
                   
                    if (thereIsAPlus)
                    {
                        deletionList[indexOfList][indexOfString] = true;
                        deletionList[middleOfPlus][indexOfString - 1] = true;
                        deletionList[middleOfPlus][indexOfString] = true;
                        deletionList[middleOfPlus][indexOfString + 1] = true;
                        deletionList[bottomOfPlus][indexOfString] = true;
                    }
                }
            }
            
        }

        private static bool ThereCanBePlus(List<string> input, int indexOfString, int middleOfPlus, int bottomOfPlus)
        {
            if (indexOfString == 0)
            {
                return false;
            }
            
            if (bottomOfPlus >= input.Count)
            {
                return false;

            }
            if (indexOfString + 1 >= input[middleOfPlus].Length)
            {
                return false;
            }
            return true;
        }
    }
}
