using System;

class NewHouse
{
    static void Main(string[] args)
    {
            int height = int.Parse(Console.ReadLine());
            Console.WriteLine(string.Format("{0}*{0}", new string('-', (height - 1) / 2)));
            for (int i = ((height - 1) / 2) - 1; i >= 0; i--)
            {
                Console.WriteLine(string.Format("{0}{1}{0}", new string('-', i), new string('*', (height - 2 * i))));
            }

            for (int i = 0; i < height; i++)
            {
                Console.WriteLine("|{0}|", new string('*', height - 2));
            }
    }
}

