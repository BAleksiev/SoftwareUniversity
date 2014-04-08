using System;
using System.Collections.Generic;
using System.Linq;

class CountOfNames
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        List<string> names = new List<string>();

        foreach (string name in input)
        {
            names.Add(name);
        }

        names.Sort();

        int count = 1;

        for (int i = 1; i < names.Count; i++)
        {
            if (names[i] == names[i - 1])
            {
                count++;
            }
            else
            {
                Console.WriteLine("{0} -> {1}", names[i - 1], count);
                count = 1;
            }

            if (i == names.Count - 1)
            {
                Console.WriteLine("{0} -> {1}", names[i], count);
            }
        }
    }
}