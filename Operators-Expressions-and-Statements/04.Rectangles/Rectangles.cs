using System;

class Rectangles
{
    static void Main()
    {

        Console.Write("Enter rectangle width: ");
        float width = float.Parse(Console.ReadLine());

        Console.Write("Enter rectangle height: ");
        float height = float.Parse(Console.ReadLine());

        float perimeter = (2 * width) + (2 * height);
        float area = width * height;

        Console.WriteLine("Rectangle Parimeter is: {0}", perimeter);
        Console.WriteLine("Rectangle Area is: {0}", area);
    }
}