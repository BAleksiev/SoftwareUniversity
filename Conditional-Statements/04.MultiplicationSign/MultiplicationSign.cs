using System;

class MultiplicationSign
{
    static void Main()
    {
        Console.WriteLine("Enter 3 real numbers in separate lines: ");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        double result = a * b * c;

        Console.Write("Result: ");

        if(result > 0)
        {
            Console.Write("+");
        }
        else if(result == 0)
        {
            Console.Write(0);
        }
        else
        {
            Console.Write("-");
        }
        Console.WriteLine();
    }
}