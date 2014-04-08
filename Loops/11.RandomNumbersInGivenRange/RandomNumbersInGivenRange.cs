using System;

class RandomNumbersInGivenRange
{
    static void Main()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Enter min: ");
        int min = int.Parse(Console.ReadLine());

        int max = 0;
        do
        {
            Console.Write("Enter max: ");
            max = int.Parse(Console.ReadLine());
        } while (max <= min);

        Random rnd = new Random();

        for (int i = 0; i < n; i++)
        {
            int num = rnd.Next(min, max+1);
            Console.Write("{0} ", num);
        }
        Console.WriteLine();
    }
}