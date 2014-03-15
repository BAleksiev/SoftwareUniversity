using System;

class Rectangles
{
    static void Main()
    {
        float width, height, perimeter, area;

        Console.Write("Enter rectangle width: ");
        width = float.Parse(Console.ReadLine());

        Console.Write("Enter rectangle height: ");
        height = float.Parse(Console.ReadLine());

        perimeter = (2 * width) + (2 * height);
        area = width * height;

        Console.WriteLine("Rectangle Parimeter is: {0}", perimeter);
        Console.WriteLine("Rectangle Area is: {0}", area);
    }
}