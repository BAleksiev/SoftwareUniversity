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

        if(inside == true)
        {
            Console.WriteLine("{0}. Coordinates x={1}, y={2} are in circle.", inside, x, y);
        }
        else
        {
            Console.WriteLine("{0}. Coordinates x={1}, y={2} are not in circle.", inside, x, y);
        }
    }
}
