using System;
using System.Collections.Generic;
using System.Linq;

class JoinLists
{
    static void Main()
    {
        string[] nums = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        string[] joins = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        List<int> numbers = new List<int>();

        foreach (string num in nums)
        {
            numbers.Add(int.Parse(num));
        }

        foreach (string num in joins)
        {
            numbers.Add(int.Parse(num));
        }

        numbers.Sort();

        numbers = numbers.Distinct().ToList();

        foreach (int num in numbers)
        {
            Console.Write("{0} ", num);
        }
        Console.WriteLine();
        Main();
    }
}
