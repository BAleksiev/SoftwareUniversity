using System;
using System.IO;

class CountingWordInText
{
    static void Main()
    {
        Console.SetIn(new StreamReader(Console.OpenStandardInput(8192)));
        string search = Console.ReadLine();
        string[] text = Console.ReadLine().Split(
            new char[] { ' ', '.', ',', '"', '@', '!', '?', '/', '\\', ':', ';', '(', ')' },
            StringSplitOptions.None);

        int count = 0;

        foreach (string word in text)
        {
            if (string.Equals(word, search, StringComparison.OrdinalIgnoreCase))
            {
                count++;
            }
        }

        Console.WriteLine(count);
    }
}