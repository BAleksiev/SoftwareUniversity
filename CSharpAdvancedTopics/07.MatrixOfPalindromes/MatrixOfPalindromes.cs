using System;

class MatrixOfPalindromes
{
    static void Main()
    {
        Console.Write("Rows: ");
        int rows = int.Parse(Console.ReadLine());

        Console.Write("Columns: ");
        int cols = int.Parse(Console.ReadLine());

        for (int i = (int)'a'; i < ((int)'a') + rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write("{0}{1}{0} ", (char)i, (char)(i + j));
            }
            Console.WriteLine();
        }
    }
}