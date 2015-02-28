using System;

class FormattingNumbers
{
    static void Main()
    {
        //Console.WriteLine("a");
        //Console.WriteLine("b");
        //Console.WriteLine("c");
        int a = int.Parse(Console.ReadLine());
        float b = float.Parse(Console.ReadLine());
        float c = float.Parse(Console.ReadLine());

        Console.WriteLine("|{0}|{1}|{2,10:0.##}|{3,-10:0.###}",(a.ToString("X").PadRight(10,' ')),(Convert.ToString(a,2).PadLeft(10,'0')),b,c);
    }
}

