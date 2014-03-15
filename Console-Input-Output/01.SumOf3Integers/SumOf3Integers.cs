using System;

class SumOf3Integers
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int numOne = int.Parse(Console.ReadLine());
        Console.Write("Enter number: ");
        int numTwo = int.Parse(Console.ReadLine());
        Console.Write("Enter number: ");
        int numThree = int.Parse(Console.ReadLine());

        int sum = numOne + numTwo + numThree;

        Console.WriteLine("{0} + {1} + {2} = {3}", numOne, numTwo, numThree, sum);
    }
}