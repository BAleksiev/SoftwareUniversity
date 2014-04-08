using System;
using System.Numerics;

class FibonacciNumbers
{
    static void Main()
    {
        Console.Write("Enter positive integer: ");
        int n = int.Parse(Console.ReadLine());

        BigInteger firstNum = 0;
        BigInteger secondNum = 1;
        BigInteger thirdNum = 0;

        if (n == 1)
        {
            Console.WriteLine(firstNum);
        }
        else
        {
            if (n >= 2)
            {
                Console.Write("{0} {1} ", firstNum, secondNum);
            }

            if (n > 2)
            {
                for (int i = 2; i < n; i++)
                {
                    thirdNum = firstNum + secondNum;
                    Console.Write("{0} ", thirdNum);
                    firstNum = secondNum;
                    secondNum = thirdNum;
                }
            }
        }
        Console.WriteLine();
    }
}