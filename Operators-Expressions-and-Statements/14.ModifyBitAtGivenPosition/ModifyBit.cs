using System;

class ModifyBit
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Enter value to change (0 or 1): ");
        int v = int.Parse(Console.ReadLine());

        Console.Write("Enter position: ");
        int p = int.Parse(Console.ReadLine());

        int mask;

        int result = (int)~(v << p) & n;

        Console.WriteLine(num2);
    }
}