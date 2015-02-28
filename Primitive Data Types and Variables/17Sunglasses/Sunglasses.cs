using System;

class Sunglasses
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int width = n * 2;
        int height = ' ' + n;
        int topDots = (width - n) * 2;
        int nexDots = (height - n) * 2;
        Console.Write(new string('*', topDots));
        Console.Write(new string(' ', n));
        Console.WriteLine(new string('*', topDots));

        for (int i = 0; i < n - 2; i++)
        {
            if (i != n / 2 - 1)
            {
                Console.WriteLine("{0}{1}{0}{2}{0}{1}{0}", new string('*', n / n), new string('/', n * 2 - 2), new string(' ', +n), new string('*', n / n), new string('/', n * 2 - 2));
            }
            else if (i == n / 2 - 1)
            {
                Console.WriteLine("{0}{1}{0}{2}{0}{1}{0}", new string('*', n / n), new string('/', n * 2 - 2), new string('|', +n), new string('*', n / n), new string('/', n * 2 - 2));
            }
        }
        Console.Write(new string('*', topDots));
        Console.Write(new string(' ', n));
        Console.WriteLine(new string('*', topDots));

        Console.WriteLine();
    }
}

