using System;

class Trapezoids
{
    static void Main()
    {

        Console.Write("Enter trapezoid side A: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Enter trapezoid side B: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Enter trapezoid height: ");
        double h = double.Parse(Console.ReadLine());

        double area = ((a + b) / 2) * h;

        Console.WriteLine("Area of given trapezoid is {0}", area);
    }
}