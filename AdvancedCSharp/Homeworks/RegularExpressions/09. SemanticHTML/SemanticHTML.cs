//////This problem is originally from the PHP Basics Exam (31 August 2014). You may check your solution here. https://judge.softuni.bg/Contests/Practice/Index/84
//You are given an HTML code, written in the old non-semantic style using tags like <div id="header">, <div class="section">, etc. Your task is to write a program that converts this HTML to semantic HTML by changing tags like <div id="header"> to their semantic equivalent like <header>.
//The non-semantic tags that should be converted are always <div>s and have either id or class with one of the following values: "main", "header", "nav", "article", "section", "aside" or "footer". Their corresponding closing tags are always followed by a comment like <!-- header -->, <!-- nav -->, etc. staying at the same line, after the tag.
//Input
//The input will be read from the console. It will contain a variable number of lines and will end with the keyword "END".
//Output
//The output is the semantic version of the input HTML. In all converted tags you should replace multiple spaces (like <header      style="color:red">) with a single space and remove excessive spaces at the end (like <footer      >). See the examples.
//Constraints
//•	Each line from the input holds either an HTML opening tag or an HTML closing tag or HTML text content.
//•	There will be no tags that span several lines and no lines that hold multiple tags.
//•	Attributes values will always be enclosed in double quotes ".
//•	Tags will never have id and class at the same time.
//•	The HTML will be valid. Opening and closing tags will match correctly.
//•	Whitespace may occur between attribute names, values and around comments (see the examples).
//•	Allowed working time: 0.1 seconds. Allowed memory: 16 MB.


using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

// taking only 85 points. 
internal class SemanticHTML
{
    private static void Main()
    {
        Regex openingTag = new Regex(@"(\s*?<)div(.*?)(id|class)\s?=\s?""(\w+)""(.*?>)");
        Regex closingTag = new Regex(@"(\s*?</)div>.*?<!.*?(\w+)");
        List<string> semanticHtmlCode = new List<string>();
        string line = Console.ReadLine();

        // I am declaring some of the variables now because I will used them in both of the regex and I don't want to eat my space declaring them every time in the while loop.
        string semanticTag = string.Empty;
        string whiteSpacesAndOpeningTag = string.Empty;
        string semanticHtmlLine = string.Empty;
        while (line != "END")
        {
            if (openingTag.IsMatch(line))
            {
                whiteSpacesAndOpeningTag = openingTag.Match(line).Groups[1].Value;
                semanticTag = openingTag.Match(line).Groups[4].Value;               
                string attributes = openingTag.Match(line).Groups[2].Value + openingTag.Match(line).Groups[5].Value;
                attributes = UnnecesesaryWhiteSpaceRemoval(attributes);
                semanticHtmlLine = whiteSpacesAndOpeningTag + semanticTag + attributes;
            }
            else if (closingTag.IsMatch(line))
            {
                whiteSpacesAndOpeningTag = closingTag.Match(line).Groups[1].Value;
                semanticTag = closingTag.Match(line).Groups[2].Value;
                semanticHtmlLine = whiteSpacesAndOpeningTag + semanticTag + ">";
            }
            else
            {
                semanticHtmlLine = line;
            }
            semanticHtmlCode.Add(semanticHtmlLine);
            line = Console.ReadLine();
        }

        Output(semanticHtmlCode);
    }

    private static void Output(List<string> semanticHtmlCode)
    {
        foreach (var line in semanticHtmlCode)
        {
            Console.WriteLine(line);
        }
    }

    private static string UnnecesesaryWhiteSpaceRemoval(string semanticHtmlLine)
    {
        // I am replacing the multiWhiteSpace inside the the opening tag and removing the space before the end of the opening tag.
        string attribute = Regex.Replace(semanticHtmlLine, @"\s{2,}", " ");
        attribute = Regex.Replace(attribute, @"\s+(?=>)", string.Empty);
        return attribute;
    }
}
