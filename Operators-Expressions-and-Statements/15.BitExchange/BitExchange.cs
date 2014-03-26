using System;

class BitExchange
{
    static void Main()
    {
        Console.Write("Enter number: ");
        uint number = 1140867093; // uint.Parse(Console.ReadLine());

        uint result = number;
        uint mask1 = 7 << 3;
        uint mask2 = 7 << 24;

        // take bit 3,4,5 and 24,25,26
        uint bits345 = number & mask1;
        uint bits2456 = number & mask2;

        // put bits in possition
        bits345 <<= 21;
        bits2456 >>= 21;

        // place zeros in bits 3,4,5 and 24,25,26
        result = ~mask1 & result; // result &= ~mask1;
        result = ~mask2 & result; // result &= ~mask2;

        // place bits in possition
        result = result | bits345; // result |= bits345;
        result = result | bits2456; // result |= bits2456;

        Console.WriteLine(result);
    }
}