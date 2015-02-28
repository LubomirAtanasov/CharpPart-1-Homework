using System;

//Joro loves a lot to play football. He used to play for his local village club “Pantera” Kaloyanovets. However, he is a programmer now and he is very busy. Now he is able to play only in the holidays and in the weekends. Joro plays in 1/2 of the holidays and once in the weekends, but not every weekend – only when he is not tired and only when he is not going to his hometown. Joro goes at his hometown h weekends in the year. The other weekends are considered “normal”. Joro is tired in 1/3 of the normal weekends. When Joro is at his hometown, he always plays football with his old friends once, at Sunday. In addition, if the year is leap, Joro plays football 3 more times additionally, in non-weekend days. We assume the year has exactly 52 weekends.
//Your task is to write a program that calculates how many times Joro plays football (rounded down to the nearest integer number).


class JoroTheFootballPlayer
{
    static void Main()
    {
        string leap = Console.ReadLine();
        int numberOfHolidays = int.Parse(Console.ReadLine());
        int hometownWeekends = int.Parse(Console.ReadLine());
        double totalPlayes = 0;
        totalPlayes += hometownWeekends;
        totalPlayes += (52 - hometownWeekends) * 2/3;
        totalPlayes += numberOfHolidays * 0.5;

        if (leap == "t")
        {
            totalPlayes += 3;
        }
        int total = (int)Math.Round(totalPlayes);
        Console.WriteLine(total); 
    }
}
