using System;

class PrimeChecker
{
    static void Main()
    {
        ulong n = ulong.Parse(Console.ReadLine());

        Console.WriteLine(IsPrime(n));
    }

    static bool IsPrime(ulong n)
    {
        bool isPrime = true;

        if (n < 2)
        {
            isPrime = false;
        }
        else
        {
            ulong counter = 1;

            while (counter <= Math.Sqrt(n))
            {
                if (n % counter == 0 && counter > 1)
                {
                    isPrime = false;
                }
                counter++;
            }
        }

        return isPrime;
    }
}
