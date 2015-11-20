////Input
//The input comes from the console on a variable number of lines and ends when the keyword "END" is received.  
//For each row of the input, the query string contains pairs field=value. Within each pair, the field name and value are separated by an equals sign, '='. The series of pairs are separated by an ampersand, '&'. The question mark is used as a separator and is not part of the query string. A URL query string may contain another URL as value. The input data will always be valid and in the format described. There is no need to check it explicitly.
//Output
//For each input line, print on the console a line containing the processed string as follows:  key=[value]nextkey=[another  value] … etc. 
//Multiple whitespace characters should be reduced to one inside value/key names, but there shouldn’t be any whitespaces before/after extracted keys and values. If a key already exists, the value is added with comma and space after other values of the existing key in the current string.  See the examples below.  
//Constraints
//•	SPACE is encoded as '+' or "%20". Letters (A-Z and a-z), numbers (0-9), the characters '*', '-', '.', '_' and other non-special symbols are left as-is.
//•	Allowed working time: 0.1 seconds. Allowed memory: 16 MB.

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

class QueryMess
{
    static string regex = @"((%20|\+)+)";
    static void Main()
    {
        string input = Console.ReadLine();
        StringBuilder result = new StringBuilder();
               
        while (input != "END")
        {
            Dictionary<string, List<string>> fieldsAndValues = new Dictionary<string, List<string>>();
            TakingTheKeyAndValue(input, fieldsAndValues);
            Result(fieldsAndValues);
            input = Console.ReadLine();
        }
        
        Console.WriteLine(result.ToString());
    }

    private static void TakingTheKeyAndValue(string input, Dictionary<string, List<string>> fieldsAndValues)
    {
        int indexOfLastEqualitySign = 0;
        int indexOfBrake = -1;

        string key = string.Empty;
        string value = string.Empty;

        for (int i = 0; i < input.Length; i++)
        {
            // I am going through the whole line and taking the keys and vlaues as substring of the start of the word to the equality sign and then to the amp. When I get a key and value I added it to a dictionary.
            if (input[i] == '=')
            {
                // here I take the key by taking a substring from the last index of ampersand or from the question mark to the index of the equality sign which is 'i' 
               key = input.Substring(indexOfBrake + 1, i - indexOfBrake - 1);                               
               indexOfLastEqualitySign = i;
               key = Regex.Replace(key, @"((%20|\+)+)", " ").Trim();

            }
            else if (input[i] == '&' || i == input.Length - 1)
            {
                if (i != input.Length - 1)
                {
                    value = input.Substring(indexOfLastEqualitySign + 1, i - indexOfLastEqualitySign - 1); // I substract one just to adjust the substring to be taken.
                }
                else
                {
                    value = input.Substring(indexOfLastEqualitySign + 1, i - indexOfLastEqualitySign);
                }
              
                indexOfBrake = i;
                value = Regex.Replace(value, @"((%20|\+)+)", " ").Trim();
                if (!fieldsAndValues.ContainsKey(key))
                {
                    fieldsAndValues.Add(key, new List<string> { value });
                }
                else
                {
                    fieldsAndValues[key].Add(value);
                }
            }            
            else if (input[i] == '?')
            {
                indexOfBrake = i;
            }
             
        }

    }
    private static void Result(Dictionary<string, List<string>> fieldsAndValues )
    {
        foreach (var dictionary in fieldsAndValues)
        {
            Console.Write("{0}=[{1}]", dictionary.Key, string.Join(", ", dictionary.Value));
        }
        Console.WriteLine();
    }
}
