using System;

class FibonacciNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine(Fib(n));
    }

    static ulong Fib(int n)
    {
        ulong firstNum = 1;
        ulong secondNum = 1;
        ulong thirdNum = 0;

        if (n == 0)
        {
            return firstNum;
        }
        else if (n == 1)
        {
            return secondNum;
        }
        else
        {
            for (int i = 2; i <= n; i++)
            {
                thirdNum = firstNum + secondNum;
                firstNum = secondNum;
                secondNum = thirdNum;
            }
        }

        return thirdNum;
    }
}