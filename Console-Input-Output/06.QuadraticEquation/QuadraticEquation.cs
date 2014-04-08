using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.Write("Enter a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter c: ");
        double c = double.Parse(Console.ReadLine());

        double d = (b * b) - (4 * a * c);

        double x1 = (-b - Math.Sqrt(d)) / (2 * a);
        double x2 = (-b + Math.Sqrt(d)) / (2 * a);

        if(d > 0)
        {
            Console.WriteLine("x1 = {0}", x1);
            Console.WriteLine("x2 = {0}", x2);
        }
        else if(d < 0)
        {
            Console.WriteLine("no real roots");
        }
        else
        {
            Console.WriteLine("x1 = x2 = {0}", x1);
        }
    }
}