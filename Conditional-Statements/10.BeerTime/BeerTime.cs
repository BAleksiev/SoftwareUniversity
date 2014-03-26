using System;
using System.Globalization;
using System.Threading;

class BeerTime
{
    static void Main()
    {
        CultureInfo enUS = new CultureInfo("en-US");
        DateTime timeNow;
        DateTime startTime = DateTime.Parse("01:00 PM");
        DateTime endTime = DateTime.Parse("03:00 AM");

        Console.Write("Enter date in format hh:mm tt ");
        string timeInput = Console.ReadLine();

        if (DateTime.TryParseExact(timeInput, "hh:mm tt", enUS, DateTimeStyles.None, out timeNow))
        {
            if (timeNow >= startTime || timeNow <= endTime)
            {
                Console.WriteLine("beer time");
            }
            else
            {
                Console.WriteLine("non-beer time");
            }
        }
        else
        {
            Console.WriteLine("invalid time");
        }
        Main();
    }
}
