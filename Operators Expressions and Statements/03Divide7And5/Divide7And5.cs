using System;

    class Divide7And5
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        bool topDots = n % 5 == 0 && n % 7 == 0;
        Console.WriteLine(topDots);
    }
}

