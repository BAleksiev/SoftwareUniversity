using System;
using System.Numerics;

class TrailingZeros
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int n = int.Parse(Console.ReadLine());

        BigInteger fact = 1;

        for (int i = n; i > 0; i--)
        {
            fact *= i;
        }

        string number = Convert.ToString(fact);
        int zeros = 0;

        for (int i = number.Length; i > 0; i--)
        {
            if (number[i-1] == '0')
            {
                zeros++;
            }
            else
            {
                break;
            }
        }

        Console.WriteLine("Trailing zeros of {0}! are: {1}", n, zeros);
        if(zeros > 0)
        {
            Console.WriteLine("Explaination: {0}", number);
        }
    }
}