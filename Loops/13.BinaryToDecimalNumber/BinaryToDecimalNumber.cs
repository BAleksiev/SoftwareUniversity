using System;

class BinaryToDecimalNumber
{
    static void Main()
    {
        Console.Write("Binary: ");
        string binaryNum = Console.ReadLine();
        long num = 0;

        for (int i = 0; i < binaryNum.Length; i++)
        {
            if (binaryNum[binaryNum.Length - i - 1] == '0')
            {
                continue;
            }

            num += (int)Math.Pow(2, i);
        }
        Console.WriteLine("Decimal: {0}", num);
    }
}