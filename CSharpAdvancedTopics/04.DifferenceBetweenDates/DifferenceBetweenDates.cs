using System;

class DifferenceBetweenDates
{
    static void Main()
    {
        Console.WriteLine("Enter two dates in separate lines (dd.MM.yyyy):");
        DateTime firstDate = DateTime.Parse(Console.ReadLine());
        DateTime secondDate = DateTime.Parse(Console.ReadLine());

        TimeSpan span = secondDate - firstDate;

        double days = span.TotalDays;

        Console.WriteLine("Days between given dates: {0}", days);
    }
}