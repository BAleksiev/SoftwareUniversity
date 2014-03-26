using System;

class NumberAsWords
{
    static void Main()
    {
        Console.Write("Enter number (0-999): ");
        string num = Console.ReadLine();

        if(int.Parse(num) >= 0 && int.Parse(num) <= 999)
        {

        }
        else
        {
            Console.WriteLine("number should be in 0 to 999 range");
        }

    }
}