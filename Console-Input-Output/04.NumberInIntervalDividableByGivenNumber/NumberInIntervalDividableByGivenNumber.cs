using System;

class NumberInIntervalDividableByGivenNumber
{
    static void Main()
    {
        int result = 0;

        Console.Write("Enter positive integer number: ");
        uint num1 = uint.Parse(Console.ReadLine());
        Console.Write("Enter positive integer number: ");
        uint num2 = uint.Parse(Console.ReadLine());

        if(num1 > num2)
        {
            num1 = num1 + num2;
            num2 = num1 - num2;
            num1 = num1 - num2;
        }

        if(num1 != num2)
        {
            for (uint i = num1; i <= num2; i++ )
            {
                if (i % 5 == 0)
                {
                    result++;
                }
            }
        }

        Console.WriteLine(result);
    }
}