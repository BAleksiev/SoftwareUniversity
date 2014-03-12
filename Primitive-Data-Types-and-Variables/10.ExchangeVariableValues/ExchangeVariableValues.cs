using System;

class ExchangeVariableValues
{
    static void Main()
    {
        int a = 5;
        int b = 10;

        Console.WriteLine("value a is: " + a);
        Console.WriteLine("value b is: " + b + "\n");

        a += b;
        b = a - b;
        a -= b;

        Console.WriteLine("value a is: " + a);
        Console.WriteLine("value b is: " + b);
    }
}