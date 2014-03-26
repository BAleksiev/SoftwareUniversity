using System;

class ExchangeIfGreater
{
    static void Main()
    {
        Console.Write("Enter two numbers in separate lines: ");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        if (a > b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        Console.WriteLine("{0} {1}", a, b);
    }
}