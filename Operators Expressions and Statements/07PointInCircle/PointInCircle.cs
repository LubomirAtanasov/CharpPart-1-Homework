using System;

    class PointInCircle
{
    static void Main()
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        bool circle = (((x * x) + (y * y)) <= 2 * 2);
        Console.WriteLine(circle);
    }
}

