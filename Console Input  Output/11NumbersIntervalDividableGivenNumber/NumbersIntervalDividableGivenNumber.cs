using System;

class NumbersIntervalDividableGivenNumber
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int result = 0;
        for (int i = a; i <= b; i++)
        {
            if (i % 5 == 0)
            {
                result++;
            }
        }
        if(result>0)
            Console.WriteLine(result);
        else
            Console.WriteLine("-");
    }
}

