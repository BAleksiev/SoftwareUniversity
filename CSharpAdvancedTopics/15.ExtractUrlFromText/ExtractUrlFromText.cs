using System;
using System.Collections.Generic;
using System.Linq;

class ExtractUrlFromText
{
    static void Main()
    {
        string input = Console.ReadLine();

        string[] splitedInput = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        List<string> urls = new List<string>();
        string url = "";

        foreach (string item in splitedInput)
        {
            if((item[0] == 'h' && item[1] == 't' && item[2] == 't' && item[3] == 'p' && item[4] == ':' 
                && item[5] == '/' && item[6] == '/')
                || (item[0] == 'w' && item[1] == 'w' && item[2] == 'w' && item[3] == '.'))
            {
                if (item[item.Length - 1] == '.')
                {
                    url = "";
                    for (int i = 0; i < item.Length - 1; i++)
                    {
                        url += item[i];
                    }
                    urls.Add(url);
                }
                else
                {
                    urls.Add(item);
                }
            }
        }

        Console.WriteLine();
        foreach (var u in urls)
        {
            Console.WriteLine(u);
        }
    }
}