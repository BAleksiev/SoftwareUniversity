using System;

class SumOf5Numbers
{
    static void Main()
    {
        Console.WriteLine("Enter five numbers in single line separated by space: ");
        string[] numbers = Console.ReadLine().Split();

        double sum = 0.0d;

        foreach (var num in numbers)
        {
            sum += double.Parse(num);
        }

        Console.WriteLine("Sum: {0}", sum);
    }
}