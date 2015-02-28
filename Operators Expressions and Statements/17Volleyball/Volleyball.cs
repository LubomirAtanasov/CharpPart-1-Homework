using System;

class Volleyball
{
    static void Main()
    { 
        string leap = Console.ReadLine();
        double numberOfHolidays = double.Parse(Console.ReadLine());
        double numberOfweekends = double.Parse(Console.ReadLine());
        double totalPlayes = 0;
        totalPlayes += numberOfweekends;
        totalPlayes += (48 - numberOfweekends) * 3 / 4;
        totalPlayes += numberOfHolidays * 2/3;

        if (leap == "leap")
        {
            totalPlayes += totalPlayes * 15 / 100;
        }
        Console.WriteLine((int)totalPlayes);
    }
}

