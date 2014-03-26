using System;

class NumbersFrom1ToN
{
    static void Main()
    {
        int n = 0;
        do
        {
            Console.Write("Enter positive integer: ");
            n = int.Parse(Console.ReadLine());
        } while (n < 0);

        int i = 1;

        while (i <= n)
        {
            Console.Write("{0} ", i);
            i++;
        }
        Console.Write("\n");
    }
}