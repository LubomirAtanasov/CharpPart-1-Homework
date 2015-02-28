using System;

class CirclePerimeterAndArea
{
    static void Main()
    {
        double r = double.Parse(Console.ReadLine());
        double result = 2 * Math.PI * r;
        double topDots = Math.PI * Math.Pow(r, 2);
        Console.WriteLine("{0:00.00}", result);
        Console.WriteLine("{0:00.00}", topDots);
    }
}

