using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

class DirectoryTraversal
{   
    static void Main()
    {
        string searchedDirectory = Console.ReadLine();
        SortedDictionary<string, Dictionary<string, double>> extensions = new SortedDictionary<string, Dictionary<string, double>>();
        DirectoryInfo directorySelected = new DirectoryInfo(searchedDirectory);
        FilesExtensions(directorySelected, extensions);
        StreamWriter writer = new StreamWriter("../../extensions.txt");
        using (writer)
        {
            WritingOnFile(writer, extensions);
        }
    }

    private static void WritingOnFile(StreamWriter writer, SortedDictionary<string, Dictionary<string, double>> extensions)
    {
        var orderedExtensions =
           extensions // ordering the main dictionarie by the count inner dictionaries
           .OrderByDescending(extension => extension.Value.Count)
           .ThenBy(extension => extension.Key);

        foreach (var extension in orderedExtensions)
        {

            writer.WriteLine(extension.Key); // writing the type of extension
            var orderedDic = extension.Value.OrderBy(dic => dic.Value); // ordering the innerDictionaries by their value - by the size of the files.
            foreach (var dic in orderedDic)
            {

                writer.WriteLine("{0}{1:F2}kb", dic.Key, dic.Value / 1024); // writing the files name with the kilobytes.

            }
        }
    }

    private static void FilesExtensions(DirectoryInfo directorySelected, SortedDictionary<string, Dictionary<string, double>> extensions)
    {
        foreach (var file in directorySelected.GetFiles())
        {
            if (!extensions.ContainsKey(file.Extension))
            {
                extensions.Add(file.Extension,
                    new Dictionary<string, double>
                    {
                       {string.Format("--{0} - ", file.Name), file.Length}
                    }
                );
            }
            else
            {
                extensions[file.Extension].Add(
                     string.Format("--{0} - ", file.Name), file.Length
                );
            }

        }
    }
}

