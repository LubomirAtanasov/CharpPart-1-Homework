// Write a program to print the numbers 1, 101 and 1001, each at a separate line. Name the program correctly. You should submit in your homework the Visual Studio project holding the source code of the PrintNumbers program.

using System;

class PrintNumbers
{
    static void Main()
    {
        int a = 1;
        int b = 101;
        int c = 1001;
        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(c);
        Console.WriteLine("The numbers are: {0}, {1} & {2}", 1, 101, 1001);
        Console.WriteLine("The numbers are: " + "1, " + "101 & " + "1001");
    }
}

