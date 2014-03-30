using System;

class FormattingNumbers
{
    static void Main()
    {
        int a = 0;
        do
        {
            Console.Write("enter integer (a) between 0 and 500: ");
            a = int.Parse(Console.ReadLine());
        } while (a < 0 || a > 500);

        Console.Write("enter floating point number (b): ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("enter floating point number (c): ");
        double c = double.Parse(Console.ReadLine());

        Console.Write("|{0,-10:X}|{1}|", a, Convert.ToString(a, 2).PadLeft(10, '0'));

        bool checkB = Convert.ToString(b).IndexOf(",") != -1;
        Console.Write(checkB ? "{0,10:F2}" : "{0,10}", b);

        bool checkC = Convert.ToString(c).IndexOf(",") != -1;
        Console.Write(checkC ? "|{0,-10:F3}|" : "|{0,-10}|", c);

        Console.WriteLine();
    }
}