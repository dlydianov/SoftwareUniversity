using System;
using System.IO;



    class OddLines
    {
        static void Main()
        {
            // Write a program that reads a text file and prints on the console its odd lines. Line numbers starts from 0. Use StreamReader.

            StreamReader reader = new StreamReader("../../Text.txt");
            using(reader)
            {
                int numberOfLine = 1;
                string line = reader.ReadLine();
                while(line != null)
                {
                    if(numberOfLine % 2 == 1)
                    {
                        Console.WriteLine(line);

                    }
                    numberOfLine++;
                    line = reader.ReadLine();
                }
            }
        }
    }
