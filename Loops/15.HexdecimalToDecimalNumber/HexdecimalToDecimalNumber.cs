using System;
using System.Globalization;

class HexdecimalToDecimalNumber
{
    static void Main()
    {
        Console.Write("Hexdecimal: ");
        string hex = Console.ReadLine();

        long num = 0;
        long power = 1;

        for (int i = hex.Length - 1; i >= 0; i--)
        {
            int val;
            switch (hex[i])
            {
                case 'A':
                    val = 10;
                    break;
                case 'B':
                    val = 11;
                    break;
                case 'C':
                    val = 12;
                    break;
                case 'D':
                    val = 13;
                    break;
                case 'E':
                    val = 14;
                    break;
                case 'F':
                    val = 15;
                    break;
                default:
                    val = (int)hex[i] - 48;
                    break;
            }
            num += val * power;
            power *= 16;
        }
        Console.WriteLine("Decimal: {0}", num);
    }
}
