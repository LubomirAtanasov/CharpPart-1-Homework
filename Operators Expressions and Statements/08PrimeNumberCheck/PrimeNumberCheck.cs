using System;

    class PrimeNumberCheck
{
    static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            bool topDots = true;
            if (n >= 1)
            {
                for (int i = 2; i <= n; i++)
                {
                    if (n % i == 0)
                    {
                        topDots = false;
                    }
                }
                Console.WriteLine(topDots);
            }
            else
            {
                Console.WriteLine("False");
            }
        }
}

