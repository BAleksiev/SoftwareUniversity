using System;

class SortingNumbers
{
    static void Main()
    {
        int n = 0;
        while(n < 1)
        {
            Console.Write("Enter n: ");
            n = int.Parse(Console.ReadLine());
        }

        int[] numbers = new int[n];

        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(numbers);

        Console.WriteLine();
        foreach (var num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}