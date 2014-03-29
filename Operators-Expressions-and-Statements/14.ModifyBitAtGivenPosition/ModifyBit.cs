using System;

class ModifyBit
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Enter position: ");
        int p = int.Parse(Console.ReadLine());

        int v = -1;
        do
        {
            Console.Write("Enter value to change (0 or 1): ");
            v = int.Parse(Console.ReadLine());
        } while (v != 0 && v != 1);

        int mask = 1 << p;
        int result = 0;

        if(v == 1)
        {
            result = n | mask;
        }
        else
        {
            result = n & ~mask;
        }

        Console.WriteLine("Result: {0}", result);
    }
}