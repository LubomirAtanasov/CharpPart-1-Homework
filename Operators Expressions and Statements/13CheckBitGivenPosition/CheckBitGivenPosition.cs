using System;

class CheckBitGivenPosition
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        bool topDots = (n & (1 << p)) > 0;
        Console.WriteLine(topDots);

    }
}

