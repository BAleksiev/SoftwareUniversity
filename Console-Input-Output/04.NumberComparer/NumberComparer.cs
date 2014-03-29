using System;

class NumberComparer
{
    static void Main()
    {
        Console.Write("Enter number one: ");
        double num1 = double.Parse(Console.ReadLine());
        Console.Write("Enter number two: ");
        double num2 = double.Parse(Console.ReadLine());

        double greater = num1 > num2 ? num1 : num2;

        Console.WriteLine("Greater number from {0} and {1} is: {2}", num1, num2, greater);
        Main();
    }
}