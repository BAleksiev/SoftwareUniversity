using System;

class RandomizeNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        bool[] numbers = new bool[n];
        Random rnd = new Random();

        for (int i = 1; i <= n; i++)
        {
            int rand = rnd.Next(1, n + 1);

            if (numbers[rand-1] == false)
            {
                Console.Write("{0} ", rand);
                numbers[rand - 1] = true;
            }
            else
            {
                i--;
            }
        }
        Console.WriteLine();
    }
}