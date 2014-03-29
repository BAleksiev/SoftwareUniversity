using System;

class BitExchange
{
    static void Main()
    {
        uint number = 0;

        do
        {
            Console.Write("Enter positive integer: ");
            number = uint.Parse(Console.ReadLine());
        } while (number <= 0);

        uint result = number;
        uint mask1 = 7 << 3;
        uint mask2 = 7 << 24;

        uint bits345 = number & mask1;
        uint bits2456 = number & mask2;

        bits345 <<= 21;
        bits2456 >>= 21;

        result &= ~mask1;
        result &= ~mask2;

        result |=bits345;
        result |= bits2456;

        Console.WriteLine("Result: {0}", result);
    }
}