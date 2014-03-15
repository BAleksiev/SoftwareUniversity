using System;

class PointInACircle
{
    static void Main()
    {
        Console.Write("Enter X coordinates: ");
        double x = double.Parse(Console.ReadLine());

        Console.Write("Enter Y coordinates: ");
        double y = double.Parse(Console.ReadLine());

        bool inside = (x * x) + (y * y) <= (2 * 2);

        Console.WriteLine(inside);
    }
}
