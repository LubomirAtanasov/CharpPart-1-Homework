using System;

class BitSifting
{
    static void Main()
    {
        ulong input = ulong.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        int count = 0;
        ulong one = 1;
        for (int i = 0; i < n; i++)
        {
            ulong num = ulong.Parse(Console.ReadLine());
            input = (input | num) ^ num;
        }
       
        while (input != 0)
        {
            ulong bit = input & one;
            if(bit == 1)
            {
                count++;
            }
            input >>= 1;
        }
        Console.WriteLine(count);
        Console.WriteLine();
    }
}


