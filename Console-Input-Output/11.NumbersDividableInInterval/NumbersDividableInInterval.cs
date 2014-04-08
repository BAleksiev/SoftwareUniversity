using System;

class NumbersDividableInInterval
{
    static void Main()
    {
        Console.WriteLine("Enter two positive integer numbers: ");
        uint start = uint.Parse(Console.ReadLine());
        uint end = uint.Parse(Console.ReadLine());

        int count = 0;
        string numbers = "";

        for (uint i = start; i <= end; i++)
        {
            if(i % 5 == 0)
            {
                if (i < end && count > 0)
                {
                    numbers += ", ";
                }

                count++;
                numbers += i;
            }
        }

        Console.WriteLine("Numbers found: {0}", count);
        Console.WriteLine(numbers);
    }
}