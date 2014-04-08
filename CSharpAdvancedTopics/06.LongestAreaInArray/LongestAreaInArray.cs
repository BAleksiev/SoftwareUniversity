using System;

class LongestAreaInArray
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        string[] elements = new string[n];

        for (int i = 0; i < n; i++)
        {
            elements[i] = Console.ReadLine();
        }

        int currPos = 0;
        int count = 1;
        string prev = "";
        int maxLength = 0;
        int maxLengthPos = 0;
        int maxElements = 1;
        int maxElPos = 0;

        for (int i = 0; i < elements.Length; i++)
        {
            if(elements[i] == prev)
            {
                count++;
                currPos = i;

                if (count > maxElements)
                {
                    maxElements = count;
                    maxElPos = currPos;
                }
            }
            else
            {
                if(count > maxElements)
                {
                    maxElements = count;
                    maxElPos = currPos;
                }
                count = 1;
                currPos = 0;
            }

            if(elements[i].Length > maxLength)
            {
                maxLength = elements[i].Length;
                maxLengthPos = i;
            }

            prev = elements[i];
        }

        Console.WriteLine();
        if (elements[maxElPos].Length * maxElements < maxLength || (elements[maxElPos].Length * maxElements == maxLength && maxLengthPos < maxElPos))
        {
            Console.WriteLine(1);
            Console.WriteLine(elements[maxLengthPos]);
        }
        else
        {
            Console.WriteLine(maxElements);
            for (int i = maxElPos - (maxElements - 1); i <= maxElPos; i++)
            {
                Console.WriteLine(elements[i]);
            }
        }
    }
}