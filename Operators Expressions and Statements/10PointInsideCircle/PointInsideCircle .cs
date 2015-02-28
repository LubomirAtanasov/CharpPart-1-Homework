using System;

    class PointInsideCircle 
{
    static void Main()
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        bool isInCircle = (Math.Pow(x-1,2) + (Math.Pow(y-1,2)) <= 1.5 * 1.5);
        bool isInRectangle = (x <=5 && x>=-1) && (y>=-1 && y <= 1);
        if (isInCircle && !isInRectangle)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}

