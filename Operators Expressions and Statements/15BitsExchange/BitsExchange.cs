using System;

class BitsExchange
{
    static void Main()
    {
        uint N = uint.Parse(Console.ReadLine());
        uint mask = 7;
        uint firstBits = (N & (mask << 3))>>3;
        uint secondBits = (N & (mask << 24))>>24;
        N = N & ~(mask << 3);
        N = N & ~(mask << 24);
        N = N | (firstBits << 24);
        N = N | (secondBits << 3);
        Console.WriteLine(N);
    }
}

