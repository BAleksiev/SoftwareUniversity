using System;

class NumbersNotDividableBy3And7
{
    static void Main()
    {
        int n = 0;
        do
        {
            Console.Write("Enter positive integer: ");
            n = int.Parse(Console.ReadLine());
        } while(n < 0);

        for (int i = 1; i <= n; i++)
        {
            if(i % 3 != 0 && i % 7 != 0)
            {
                Console.Write("{0} ", i);
            }
        }
        Console.WriteLine();
    }
}