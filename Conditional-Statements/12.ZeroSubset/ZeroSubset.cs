using System;
using System.Collections.Generic;

class ZeroSubset
{
    static void Main()
    {
        const int len = 5;
        string pattern;
        int[] nums = new int[5];

        for (int i = 0; i < 5; i++)
        {
            Console.Write("Enter a value for number {0}: ", i+1);
            nums[i] = int.Parse(Console.ReadLine());
        }

        int zerosCount = 0, currentSum;
        List<int> numbers;

        for (int i = 1, m = (int)Math.Pow(2, len); i < m; i++)
        {
            pattern = Convert.ToString(i, 2).PadLeft(len, '0');
            currentSum = 0;
            numbers = new List<int>();
            for (int j = 0; j < len; j++)
            {
                if (pattern[j] == '1')
                {
                    currentSum += nums[j];
                    numbers.Add(nums[j]);
                }
            }
            if (currentSum == 0)
            {
                zerosCount++;
                if (numbers.Count > 1)
                {
                    for (int j = 0; j < numbers.Count - 1; j++)
                    {
                        Console.Write("{0} + ", numbers[j]);
                    }
                    Console.WriteLine("{0} = 0", numbers[numbers.Count - 1]);
                }
                else
                {
                    Console.WriteLine("{0} = 0", numbers[0]);
                }
            }
        }

        if(zerosCount == 0)
        {
            Console.WriteLine("no zero suset");
        }
    }
}