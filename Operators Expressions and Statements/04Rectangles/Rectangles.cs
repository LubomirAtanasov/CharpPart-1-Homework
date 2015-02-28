using System;

    class Rectangles
{
    static void Main()
    {
        double widht = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());
        double perimeter = 2 * widht + 2 * height;
        double area = height * widht;
        Console.WriteLine(perimeter);
        Console.WriteLine(area);
    }
}

