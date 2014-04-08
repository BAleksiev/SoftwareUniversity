using System;

class CalculateFactorialFormula
{
    static void Main()
    {
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter X: ");
        int x = int.Parse(Console.ReadLine());

        double result = 1;
        double fact = 1;
        double del = 1;

        for (int i = 1; i <= n; i++)
        {
            fact *= i;
            del *= x;
            result += fact / del;
        }

        Console.WriteLine("{0:F5}", result);
    }
}