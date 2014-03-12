using System;

class NullValuesArithmetic
{
    static void Main()
    {
        int? nullInt = null;
        double? nullReal = null;
        Console.WriteLine("Null value: " + nullInt);
        Console.WriteLine("Null value: " + nullReal);

        nullInt += 7;
        nullReal += 4.5;
        Console.WriteLine("Number + null value: " + nullInt);
        Console.WriteLine("Number + null value: " + nullReal);

        nullInt = 7;
        nullReal = 4.5;
        Console.WriteLine("Number value: " + nullInt);
        Console.WriteLine("Number value: " + nullReal);
    }
}