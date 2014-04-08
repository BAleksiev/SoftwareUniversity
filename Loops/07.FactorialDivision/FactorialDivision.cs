using System;
using System.Numerics;

class FactorialDivision
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

        BigInteger factNK = 1;
        BigInteger result2 = 1;
        BigInteger result = 0;

        for (int i = n; i > k; i--)
        {
            factNK *= i;
        }

        for (int i = 2; i <= n - k; i++)
        {
            result2 *= i;
        }

        result = factNK / result2;
        Console.WriteLine(result);
        Main();
    }
}