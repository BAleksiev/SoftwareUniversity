using System;

class DecimalToBinaryNumber
{
    static void Main()
    {
        Console.Write("Decimal: ");
        long num = long.Parse(Console.ReadLine());

        Console.WriteLine("Binary: {0}", Convert.ToString(num, 2));
    }
}