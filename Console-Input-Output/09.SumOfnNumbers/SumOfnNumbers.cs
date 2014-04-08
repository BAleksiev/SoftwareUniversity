using System;

class SumOfnNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter positive integer: ");
        int n = int.Parse(Console.ReadLine());

        double sum = 0.0d;

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter number {0}: ", i+1);
            sum += double.Parse(Console.ReadLine());
        }

        Console.WriteLine("Sum: {0}", sum);
    }
}
