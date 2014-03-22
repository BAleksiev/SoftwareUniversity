using System;

class BitwiseExtractBit
{
    static void Main()
    {
        uint num;
        int p = 3;

        Console.Write("Enter positive integer: ");
        while(!uint.TryParse(Console.ReadLine(), out num))
        {
            Console.Write("Enter positive integer: ");
        }

        int bit = (int)(num >> p) & 1;

        Console.WriteLine("The bit in position #{0} of number {1} is: {2}", p, num, bit);
    }
}