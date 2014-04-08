using System;

class TheBiggestOf3Numbers
{
    static void Main()
    {
        Console.WriteLine("Enter three numbers: ");
        double num1 = double.Parse(Console.ReadLine());
        double num2 = double.Parse(Console.ReadLine());
        double num3 = double.Parse(Console.ReadLine());

        Console.WriteLine("The biggest number is {0}", Math.Max(num1, Math.Max(num2, num3)));
    }
}