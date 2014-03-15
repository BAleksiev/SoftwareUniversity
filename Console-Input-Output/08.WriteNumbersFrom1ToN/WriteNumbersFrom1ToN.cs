using System;

class WriteNumbersFrom1ToN
{
    static void Main()
    {
        int startNum = 1;

        Console.Write("Enter integer number: ");
        int n = int.Parse(Console.ReadLine());

        if (n >= 1)
        {
            for (int i = startNum; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }
        else
        {
            for (int i = startNum; i >= n; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}