using System;

class SumOfNumbers
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        double result = 0;
        for (int i = 0; i < a; i++)
        {
            result += double.Parse(Console.ReadLine());
        }
        Console.WriteLine(result);
    }
}

