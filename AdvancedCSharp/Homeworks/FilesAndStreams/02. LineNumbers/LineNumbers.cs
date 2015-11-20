using System;
using System.IO;
using System.Text;
class LineNumbers
{
    static void Main()
    {
        // Write a program that reads a text file and inserts line numbers in front of each of its lines. The result should be written to another text file. Use StreamReader in combination with StreamWriter.

        StreamReader reader = new StreamReader("../../Text.txt");
        StreamWriter writer = new StreamWriter("../../Copy.txt");

        using(reader)
        {
            using(writer)
            {
                string line = reader.ReadLine();
                int lineNumber = 1;
                while(line != null)
                {                  
                    writer.WriteLine("{0, 5}. {1}", lineNumber, line);
                    line = reader.ReadLine();
                    lineNumber++;
                }
               
            }
        }
    }
}
