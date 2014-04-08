using System;

class DecimalToHexadecimalNumber
{
    static void Main()
    {
        long num = long.Parse(Console.ReadLine());
        string hex = "";

        if (num == 0)
        {
            hex = "0";
        }
        else
        {
            while (num > 0)
            {
                long remain = num % 16;
                num /= 16;

                switch (remain)
                {
                    case 10:
                        hex = "A" + hex;
                        break;
                    case 11:
                        hex = "B" + hex;
                        break;
                    case 12:
                        hex = "C" + hex;
                        break;
                    case 13:
                        hex = "D" + hex;
                        break;
                    case 14:
                        hex = "E" + hex;
                        break;
                    case 15:
                        hex = "F" + hex;
                        break;
                    default:
                        hex = remain + hex;
                        break;
                }
            }
        }
        Console.WriteLine(hex);
    }
}