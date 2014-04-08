using System;
using System.Numerics;

class CatalanNumbers
{
    static void Main()
    {
        int n = 0;

        do
        {
            Console.Write("Enter number: ");
            n = int.Parse(Console.ReadLine());
        } while (n <= 1 || n >= 100);

        BigInteger catNum = 1;
        BigInteger fact1 = 1;
        BigInteger fact2 = 1;

        for (int i = n*2; i > n; i--)
        {
            fact1 *= i;
        }

        for (int i = 2; i <= n+1; i++)
        {
            fact2 *= i;
        }

        catNum = fact1 / fact2;

        Console.WriteLine(catNum);
    }
}
