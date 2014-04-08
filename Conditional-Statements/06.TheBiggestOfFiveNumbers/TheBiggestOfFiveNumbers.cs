using System;

class TheBiggestOfFiveNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter three numbers: ");
        double num1 = double.Parse(Console.ReadLine());
        double num2 = double.Parse(Console.ReadLine());
        double num3 = double.Parse(Console.ReadLine());
        double num4 = double.Parse(Console.ReadLine());
        double num5 = double.Parse(Console.ReadLine());

        double biggestNumber = Math.Max(num1, Math.Max(num2, Math.Max(num3, Math.Max(num4, num5))));

        Console.WriteLine("The biggest number is {0}", biggestNumber);
    }
}