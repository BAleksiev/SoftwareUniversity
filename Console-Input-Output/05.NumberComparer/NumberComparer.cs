using System;

class NumberComparer
{
    static void Main()
    {
        Console.Write("Enter number one: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("Enter number two: ");
        int num2 = int.Parse(Console.ReadLine());

        int greater = num1 > num2 ? num1 : num2;

        Console.WriteLine("Greater number from {0} and {1} is: {2}", num1, num2, greater);
    }
}