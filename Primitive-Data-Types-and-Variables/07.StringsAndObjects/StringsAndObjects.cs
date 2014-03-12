using System;

class StringsAndObjects
{
    static void Main()
    {
        string str1 = "Hello";
        string str2 = "World";
        object obj = str1 + " " + str2;
        string finalStr = Convert.ToString(obj);

        Console.WriteLine(finalStr);
    }
}
