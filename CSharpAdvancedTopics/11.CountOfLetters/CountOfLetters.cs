using System;
using System.Collections.Generic;
using System.Linq;

class CountOfLetters
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        List<char> letters = new List<char>();

        foreach (string letter in input)
        {
            letters.Add(Convert.ToChar(letter));
        }

        letters.Sort();

        int count = 1;

        for (int i = 1; i < letters.Count; i++)
        {
            if(letters[i] == letters[i - 1])
            {
                count++;
            }
            else
            {
                Console.WriteLine("{0} -> {1}", letters[i - 1], count);
                count = 1;
            }

            if (i == letters.Count - 1)
            {
                Console.WriteLine("{0} -> {1}", letters[i], count);
            }
        }
    }
}