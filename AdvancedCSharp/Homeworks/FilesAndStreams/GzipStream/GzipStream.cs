using System;
using System.IO;
using System.IO.Compression;


class GzipStream
{
    const string sourceFile = "../../file.txt";
    const string destination = "../../";

   
    public static void SplitFile(string inputFile, int parts, string path)
    {
        byte[] buffer = new byte[4096];
        DirectoryInfo directorySelected = new DirectoryInfo(destination);
        using (Stream originalFile = File.OpenRead(sourceFile))
        {
            int index = 1;
            while (originalFile.Position < originalFile.Length)
            {

                using (Stream compressedFile = File.Create(path + "\\" + index + ".gz"))
                {
                    using (GZipStream compression = new GZipStream(compressedFile, CompressionMode.Compress))
                    {
                        int chunkBytesRead = 0;
                        while (chunkBytesRead < originalFile.Length / parts)
                        {
                            int bytesRead = originalFile.Read(buffer, 0, buffer.Length);

                            if (bytesRead == 0)
                            {
                                break;
                            }
                            chunkBytesRead += bytesRead;

                            compression.Write(buffer, 0, bytesRead);
                        }
                    }
                   
                    
                }
                index++;
            }
        }
    }
    private static void Assemble(int parts)
    {
        byte[] buffer = new byte[4096];
        for (int i = 1; i <= parts; i++)
        {
            string source = String.Format("../../{0}.gz", i);
            FileStream partOfFile = new FileStream(source, FileMode.Open);
            FileStream assembledFile = new FileStream("../../assembled.txt", FileMode.Append);

            using (partOfFile)
            {
                using (assembledFile)
                {
                    using (GZipStream decompression = new GZipStream(partOfFile, CompressionMode.Decompress))
                    {
                        while (true)
                        {
                            int bytesRead = decompression.Read(buffer, 0, buffer.Length);
                            if (bytesRead == 0)
                            {
                                break;
                            }
                            assembledFile.Write(buffer, 0, bytesRead);
                        }
                    }
                   

                }
            }
        }
    }
    static void Main()
    {
        Console.Write("Enter in how many parts do you want the file to be sliced: ");
        int parts = int.Parse(Console.ReadLine());
        
        SplitFile(sourceFile, parts, destination);
      
        Assemble(parts);
    }
}


