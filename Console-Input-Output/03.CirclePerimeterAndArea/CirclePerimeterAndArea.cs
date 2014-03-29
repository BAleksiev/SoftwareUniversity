using System;

class CirclePerimeterAndArea
{
    static void Main()
    {
        Console.Write("Enter circle radius: ");
        double radius = double.Parse(Console.ReadLine());

        double perimeter = Math.Round((2 * Math.PI * radius), 2);
        double area = Math.Round((Math.PI * (radius * radius)), 2);

        Console.WriteLine("Circle perimeter is: {0}", perimeter);
        Console.WriteLine("Circle area is: {0}", area);
    }
}