using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text.RegularExpressions;

class WordsCount
{
    // Write a program that reads a list of words from the file words.txt and finds how many times each of the words is contained in another file text.txt. Matching should be case-insensitive. Write the results in file results.txt. Sort the words by frequency in descending order. Use StreamReader in combination with StreamWriter.

  

    static void Main()
    {
        StreamReader readerText = new StreamReader("../../Text.txt");
        StreamReader readerWords = new StreamReader("../../words.txt");
        StreamWriter writer = new StreamWriter("../../result.txt");

        List<string> words = new List<string>();
        SortedDictionary<string, int> result = new SortedDictionary<string, int>();


        // First Part. Reading the files
        using (readerText)
        {
            using (readerWords)
            {
                words = WordsToMatch(readerWords);
                string line = readerText.ReadToEnd();

                for (int i = 0; i < words.Count; i++)
                {
                    string pattern = String.Format(@"\b{0}\b", words[i]);
                    Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);
                    int numberOfTimesTheWordIsMatched = 0;
                    MatchCollection matches = regex.Matches(line);
                    foreach (var match in matches)
                    {
                        numberOfTimesTheWordIsMatched++;
                    }

                    result.Add(words[i], numberOfTimesTheWordIsMatched);
                }

            }
        }

        // Second Part. Writing in the text file the result.
        using (writer)
        {
            foreach (var item in result.OrderByDescending(key => key.Value))
            {
                writer.WriteLine("{0} - {1}", item.Key, item.Value);
            }

        }
    }
    private static List<string> WordsToMatch(StreamReader readerWords)
    {
        // Here I am filling the words that I need to check with the Regex in a List.
        List<string> words = new List<string>();
        string lineOfWords = readerWords.ReadLine();
        while (lineOfWords != null) // taking the words in a List so it can easily be accessed.
        {
            string[] word = lineOfWords.Split(' ');
            for (int i = 0; i < word.Length; i++)
            {
                words.Add(word[i]);
            }
            lineOfWords = readerWords.ReadLine();
        }
        return words;
    }

}

