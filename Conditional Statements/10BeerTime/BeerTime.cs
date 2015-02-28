﻿using System;

    class BeerTime
{
    static void Main()
    {
        string startBeerTime = "1:00 PM";
        string endBeerTime = "3:00 AM";
        string preMidnight = "23:59 PM";
        string midnight = "12:00 AM";
        DateTime start = Convert.ToDateTime(startBeerTime);
        DateTime end = Convert.ToDateTime(endBeerTime);
        DateTime preMid = Convert.ToDateTime(preMidnight);
        DateTime mid = Convert.ToDateTime(midnight);
        DateTime time;
        string input = Console.ReadLine();
        if (DateTime.TryParseExact(input, "h:mm tt", CultureInfo.CreateSpecificCulture("en-US"), DateTimeStyles.None, out time))
        {
            if (time >= start && time <= preMid)
            {
                Console.WriteLine("Beer time!");
            }
            else if (time >= mid && time < end)
            {
                Console.WriteLine("Beer time!");
            }
            else
            {
                Console.WriteLine("Non-beer time!");
            }
        }
        else
        {
            Console.WriteLine("Invalid time!");
        }
    }
}


    


