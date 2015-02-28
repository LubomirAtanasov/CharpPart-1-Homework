using System;

    class GravitationTheMoon
{
    static void Main()
    {
        double weightOnEarth = double.Parse(Console.ReadLine());
        double weightOnMoon = weightOnEarth * 0.17;
        Console.WriteLine(weightOnMoon);
    }
}

