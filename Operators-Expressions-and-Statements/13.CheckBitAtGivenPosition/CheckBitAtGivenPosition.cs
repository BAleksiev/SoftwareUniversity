using System;

class CheckBitAtGivenPosition
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int num = int.Parse(Console.ReadLine());

        Console.Write("Enter position to check: ");
        int p = int.Parse(Console.ReadLine());

        int bit = (int)(num >> p) & 1;
        bool bitCheck = bit == 1;

        Console.WriteLine("{0}. Binary represendation of {1} have number {2} at possition {3}.", bitCheck, num, bit, p);
    }
}