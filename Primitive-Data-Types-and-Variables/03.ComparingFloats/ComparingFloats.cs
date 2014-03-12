using System;

class ComparingFloats
{
    static void Main()
    {
        double eps = 0.000001;
        double firstNum;
        double secondNum;

        Console.WriteLine("Enter first number:");
        firstNum = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter second number:");
        secondNum = double.Parse(Console.ReadLine());

        if (Math.Abs(firstNum - secondNum) < eps)
        {
            Console.WriteLine("Equal");
        }
        else
        {
            Console.WriteLine("Not equal");
        }
    }
}