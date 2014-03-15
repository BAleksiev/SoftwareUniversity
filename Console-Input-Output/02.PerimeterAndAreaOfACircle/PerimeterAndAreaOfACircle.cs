using System;

class PerimeterAndAreaOfACircle
{
    static void Main()
    {
        Console.Write("Enter circle radius: ");
        double radius = double.Parse(Console.ReadLine());

        double perimeter = 2 * Math.PI * radius;
        double area = Math.PI * (radius * radius);

        Console.WriteLine("Circle perimeter is: {0}", perimeter);
        Console.WriteLine("Circle area is: {0}", area);
    }
}