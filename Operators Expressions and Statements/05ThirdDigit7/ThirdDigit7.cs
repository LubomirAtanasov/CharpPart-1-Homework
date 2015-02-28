using System;

class ThirdDigit7
{
    static void Main()
    {
        int n = Math.Abs(int.Parse(Console.ReadLine()));
        bool isSeven = (n / 100) % 10 == 7;
        Console.WriteLine(isSeven);


    }
}

