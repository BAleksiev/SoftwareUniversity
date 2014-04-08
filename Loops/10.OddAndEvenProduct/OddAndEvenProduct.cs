using System;

class OddAndEvenProduct
{
    static void Main()
    {
        int odd = 1;
        int even = 1;

        string[] numbers = Console.ReadLine().Split();

        for (int i = 0; i < numbers.Length; i++)
        {
            int number = int.Parse(numbers[i]);

            if (i % 2 == 0)
            {
                even *= number;
            }
            else
            {
                odd *= number;
            }
        }

        if (even == odd)
        {
            Console.WriteLine("yes");
            Console.WriteLine("product = {0}", even);
        }
        else
        {
            Console.WriteLine("no");
            Console.WriteLine("odd_product = {0}", odd);
            Console.WriteLine("even_product = {0}", even);
        }
    }
}