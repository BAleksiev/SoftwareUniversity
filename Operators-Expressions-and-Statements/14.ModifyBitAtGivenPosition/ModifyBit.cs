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

        int num2;

        if (v == 1)
        {
            num2 = (int)(n >> p) | v;
        }
        else if(v == 0)
        {
            num2 = (int)(n >> p) & v;
        }
        else
        {
            num2 = (int)(n >> p) & 0;
        }

        int result = (int)(num2 << p) | n;

        Console.WriteLine(result);
    }
}