using System;

class MatrixOfNumbers
{
    static void Main()
    {
        int n = 0;

        do
        {
            Console.Write("Enter positive integer: ");
            n = int.Parse(Console.ReadLine());
        } while (n < 1 || n > 20);

        for (int row = 1; row <= n; row++)
        {
            for (int i = row; i < row + n; i++)
            {
                Console.Write("{0,-3}", i);
            }
            Console.WriteLine();
        }
    }
}