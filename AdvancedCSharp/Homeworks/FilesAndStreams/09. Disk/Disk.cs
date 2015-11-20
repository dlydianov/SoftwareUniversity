using System;



class Disk
{
    static bool IsPointInsideTheDisk(int sizeOfField, int radius, int x, int y)
    {
        int centerX = sizeOfField / 2 + 1;
        int centerY = sizeOfField / 2 + 1;

        if ((x - centerX) * (x - centerX) + (y - centerY) * (y - centerY) <= radius * radius)
        {
            return true;
        }
        return false;
    }
    static void Main()
    {
        // In geometry, a disk is the region in a plane bounded by a circle (it also includes the circle itself). Your task is to print a disk on the console by a given radius R in a square field of size N x N (see the examples below).

        // getting input

        int sizeOfField = int.Parse(Console.ReadLine());
        int radius = int.Parse(Console.ReadLine());

        for (int y = 1; y <= sizeOfField; y++)
        {
            for (int x = 1; x <= sizeOfField; x++)
            {
                if (IsPointInsideTheDisk(sizeOfField, radius, x, y))
                {
                    Console.Write('*');
                }
                else
                {
                    Console.Write('.');
                }
            }
            Console.WriteLine();
        }

    }
}

