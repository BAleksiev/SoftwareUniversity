using System;

class PrintASCIITable
{
    static void Main(string[] args)
    {
        Console.WriteLine("   Dec\t|  Hex\t| Char");
        Console.WriteLine("----------------------");

        for (int i = 0; i <= 255; i++)
        {
            Console.WriteLine("   {0}\t|   {1:X}\t|  {2}", i, i, (char)i);
        }

        Console.WriteLine("----------------------");
        Console.WriteLine("   Dec\t|  Hex\t| Char");
    }
}