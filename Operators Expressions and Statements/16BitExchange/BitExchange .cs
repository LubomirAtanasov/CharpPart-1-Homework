using System;

class BitExchange 
{
    static void Main()
    {
        uint N = uint.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        int q = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        if (Math.Max(p, q) + k - 1 > 31)
        {
            Console.WriteLine("Out of range!");
        }
        else if(Math.Min (p,q) + k -1 >= Math.Max(p,q))
        {
            Console.WriteLine("Overlapping!");
        }
        else
        {
            for (int i = p; i <= p + k - 1; i++)
            {
                uint mask = 1;
                uint bitQ = (N & (mask << q)) >> q;
                uint bitp = (N & (mask << i)) >> i;
                N = N & ~(mask << i);
                N = N & ~(mask << q);
                N = N | (bitp << q);
                N = N | (bitQ << i);
                q++;
            }
        }
        Console.WriteLine(N);
    }
}

    