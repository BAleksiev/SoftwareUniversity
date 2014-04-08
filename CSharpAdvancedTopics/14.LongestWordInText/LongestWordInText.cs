using System;

class LongestWordInText
{
    static void Main()
    {
        string input = Console.ReadLine();

        string[] words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        int maxLength = 0;
        string longestWord = "";

        foreach (var word in words)
        {
            if(word[word.Length - 1] == '.' && word.Length > maxLength)
            {
                longestWord = "";
                maxLength = word.Length - 1;
                for (int i = 0; i < word.Length - 1; i++)
                {
                    longestWord += word[i];
                }
            }
            else if(word.Length > maxLength)
            {
                longestWord = "";
                maxLength = word.Length;
                for (int i = 0; i < word.Length; i++)
                {
                    longestWord += word[i];
                }
            }
        }

        Console.WriteLine(longestWord);
    }
}