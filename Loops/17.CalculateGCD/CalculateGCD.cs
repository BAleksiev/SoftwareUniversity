using System;

class CalculateGCD
{
    static void Main()
    {
        Console.Write("Enter a: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Enter b: ");
        int b = int.Parse(Console.ReadLine());

        if (a < 0)
        {
            a *= -1;
        }
        if (b < 0)
        {
            b *= -1;
        }

        while (a != 0 && b != 0)
        {
            if (a > b)
            {
                a %= b;
            }
            else
            {
                b %= a;
            }
        }

        int result = 0;

        if (a == 0)
        {
            result = b;
        }
        else
        {
            result = a;
        }

        Console.WriteLine("GCD: {0}", result);
    }
}