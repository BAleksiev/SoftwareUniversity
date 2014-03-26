using System;

class BonusScore
{
    static void Main()
    {
        Console.Write("Enter score (1 to 9): ");
        int score = int.Parse(Console.ReadLine());

        int result = 0;

        if (score >= 1 && score <= 3)
        {
            result = score * 10;
        }
        else if (score >= 4 && score <= 6)
        {
            result = score * 100;
        }
        else if (score >= 7 && score <= 9)
        {
            result = score * 1000;
        }

        if (score >= 1 && score <= 9)
        {
            Console.WriteLine("Result: {0}", result);
        }
        else
        {
            Console.WriteLine("invalid score");
        }
    }
}