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
        Console.WriteLine("Number + null value: {0}", nullInt);
        Console.WriteLine("Number + null value: {0}", nullReal);

        nullInt = 7;
        nullReal = 4.5;
        Console.WriteLine("Number value: {0}", nullInt);
        Console.WriteLine("Number value: {0}", nullReal);
    }
}