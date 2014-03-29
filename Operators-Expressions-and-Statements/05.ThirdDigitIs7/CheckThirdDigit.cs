using System;

class CheckThirdDigit
{
    static void Main()
    {
        Console.Write("Enter number: ");
        string number = Console.ReadLine();

        char thirdDigit;
        bool isSeven = false;

        if (number.Length >= 3)
        {
            thirdDigit = number[number.Length - 3];
            isSeven = thirdDigit == '7';

            Console.WriteLine("{0}. The third digit from right to left is {1}", isSeven, thirdDigit);
        }
        else
        {
            Console.WriteLine("{0}. There are no third digit.", isSeven);
        }
    }
}