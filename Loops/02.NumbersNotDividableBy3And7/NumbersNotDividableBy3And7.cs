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


    }
}