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

        Console.WriteLine("|{0,-10:X}|{1}|{2,10:F2}|{3,-10:F3}|", a, Convert.ToString(a, 2).PadLeft(10, '0'), b, c);
    }
}