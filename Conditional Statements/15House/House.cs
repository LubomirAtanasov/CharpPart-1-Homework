using System;

    class House
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());

        for (int i = 0; i < 1; i++)
        {
            Console.WriteLine("{0}{1}{0}",
                new string('.', ((N - 1) / 2) - i),
                new string('*', 1));
        }

        for (int i = 1; i < N / 2; i++)
        {
            Console.WriteLine("{0}{1}{2}{1}{0}",
                new string('.', ((N - 1) / 2) - i),
                new string('*', 1),
                new string('.', 2 * i - 1));
        }

        Console.WriteLine(new string('*', N));


        int topDots = N / 4;
        for (int i = N / 2 + 1; i < N - 1; i++)
        {
            Console.WriteLine("{0}{1}{2}{1}{0}",
                new string('.', N / 4),
                new string('*', 1),
                new string('.', N - 2 * topDots - 2));
 
        }
        Console.Write(new string ('.', topDots));
        Console.Write(new string('*', N - 2 * topDots));
        Console.WriteLine(new string ('.', topDots));

        Console.WriteLine();
    }
}

