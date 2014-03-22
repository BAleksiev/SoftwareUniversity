using System;

class ExtractBitFromIntager
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int num = int.Parse(Console.ReadLine());

        Console.Write("Enter position of the index: ");
        int p = int.Parse(Console.ReadLine());

        int bit = (int)(num >> p) & 1;

        Console.WriteLine("The bit in position #{0} of number {1} is: {2}", p, num, bit);
    }
}