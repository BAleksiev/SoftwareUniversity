using System;
using System.Collections.Generic;

class PrimesInGivenRange
{
    static void Main()
    {
        int startNum = int.Parse(Console.ReadLine());
        int endNum = int.Parse(Console.ReadLine());

        List<int> primes =  FindPrimesInRange(startNum, endNum);

        int counter = 0;

        foreach (var prime in primes)
        {
            Console.Write("{0}", prime);
            counter++;

            if(counter < primes.Count)
            {
                Console.Write(", ");
            }
        }

        Main();
    }

    static List<int> FindPrimesInRange(int startNum, int endNum)
    {
        List<int> primes = new List<int>();

        for (int i = startNum; i <= endNum; i++)
        {
            bool isPrime = true;

            if (i < 2)
            {
                isPrime = false;
            }
            else
            {
                int counter = 1;

                while (counter <= Math.Sqrt(i))
                {
                    if (i % counter == 0 && counter > 1)
                    {
                        isPrime = false;
                    }
                    counter++;
                }

                if(isPrime)
                {
                    primes.Add(i);
                }
            }
        }

        return primes;
    }

}