using System;

class QuadraticEquation
{
    static void Main()
    {           
        double coeffiA = double.Parse(Console.ReadLine());
        double coeffiB = double.Parse(Console.ReadLine());
        double coeffiC = double.Parse(Console.ReadLine());
        double determinant = (coeffiB * coeffiB) - (4 * coeffiA * coeffiC);

        if (determinant < 0)
        {
            Console.WriteLine("DETERMINANT < 0 - > NO SOLUTION");
        }
        else if (determinant > 0)
        {
            Console.WriteLine("X1 - {0}", (-coeffiB - Math.Sqrt(determinant)) / (2 * coeffiA));
            Console.WriteLine("X2 - {0}", (-coeffiB + Math.Sqrt(determinant)) / (2 * coeffiA));
        }
        else
        {
            Console.WriteLine("DETERMINANT = 0 - > SOLUTION: {0}", (-coeffiB / (2 * coeffiA)));
        }     	
    }
}

