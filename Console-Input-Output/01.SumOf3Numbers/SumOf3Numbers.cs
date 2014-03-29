using System;

class SumOf3Numbers
{
    static void Main()
    {
        Console.Write("Enter number: ");
        double numOne = double.Parse(Console.ReadLine());
        Console.Write("Enter number: ");
        double numTwo = double.Parse(Console.ReadLine());
        Console.Write("Enter number: ");
        double numThree = double.Parse(Console.ReadLine());

        double sum = numOne + numTwo + numThree;

        Console.WriteLine("{0} + {1} + {2} = {3}", numOne, numTwo, numThree, sum);
    }
}