using System;
using System.Numerics;

class CalculateFactorialDivision
{
    static void Main()
    {
        int n = 0;
        int k = 0;

        do
        {
            Console.Write("Enter N: ");
            n = int.Parse(Console.ReadLine());
        } while (n < 3 || n >= 100);

        do
        {
            Console.Write("Enter K: ");
            k = int.Parse(Console.ReadLine());
        } while (k <= 1 || k >= n);

        BigInteger result = 1;

        for (int i = n; i > k; i--)
        {
            result *= i;
        }

        Console.WriteLine("{0}! / {1}! = {2}", n, k, result);
    }
}