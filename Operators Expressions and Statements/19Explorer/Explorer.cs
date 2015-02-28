using System;

    class Explorer
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int outside = (n -1) / 2;
        int inside = 1;
 
        Console.Write(new string('-', outside));
        Console.Write(new string('*', 1));
        Console.Write(new string('-', outside));
        Console.WriteLine();
 
        while (outside != 0)
        {
            Console.Write(new string('-', outside - 1));
            Console.Write(new string('*', 1));
            Console.Write(new string('-', inside));
            Console.Write(new string('*', 1));
            Console.Write(new string('-', outside - 1));
            Console.WriteLine();
            inside += 2;
            outside--;
        }
 
        outside++;
        inside -= 2;
 
        while (outside != 0)
        {
            if (inside - 2 < 0)
            {
                break;
            }
            else
            {
                Console.Write(new string('-', outside));
                Console.Write(new string('*', 1));
                Console.Write(new string('-', inside - 2));
                Console.Write(new string('*', 1));
                Console.Write(new string('-', outside));
                Console.WriteLine();
                inside -= 2;
                outside++;
            }
        }
 
        Console.Write(new string('-', outside));
        Console.Write(new string('*', 1));
        Console.Write(new string('-', outside));
        Console.WriteLine();
    }

}



