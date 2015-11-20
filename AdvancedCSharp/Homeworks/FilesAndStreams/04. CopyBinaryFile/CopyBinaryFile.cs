using System.IO;

class CopyBinaryFile
{
    // Write a program that copies the contents of a binary file (e.g. image, video, etc.) to another using FileStream. You are not allowed to use the File class or similar helper classes.
    static void Main()
    {
        FileStream copiedFile = new FileStream("../../toCopy.jpg", FileMode.Open);
        FileStream newFile = new FileStream("../../copiedImage.jpg", FileMode.Create);

        using(copiedFile)
        {
            using(newFile)
            {
                
                byte[] buffer = new byte[4096];

                while(true)
                {
                    int readBytes = copiedFile.Read(buffer, 0, buffer.Length);
                    if(readBytes == 0)
                    {
                        break;
                    }
                    newFile.Write(buffer, 0, readBytes);
                }
            }
        }

    }
}

