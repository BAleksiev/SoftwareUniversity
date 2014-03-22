using System;

class ExchangeVariableValues
{
    static void Main()
    {
        int a = 5;
        int b = 10;

        Console.WriteLine("value of \"a\" is: " + a);
        Console.WriteLine("value of \"b\" is: " + b + "\n");

        a += b;
        b = a - b;
        a -= b;

        Console.WriteLine("value of \"a\" is: " + a);
        Console.WriteLine("value of \"b\" is: " + b);
    }
}