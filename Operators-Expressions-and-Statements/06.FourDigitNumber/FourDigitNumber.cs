using System;

class FourDigitNumber
{
    static void Main()
    {
        int sum;
        string number, reversed, lastInFront, exchanged;

        do
        {
            Console.Write("Enter a four-digit number (cannot start with 0): ");
            number = Console.ReadLine();

        } while (number.Length != 4 || number[0] == '0');

        reversed = Convert.ToString(number[3]) + Convert.ToString(number[2]) + Convert.ToString(number[1]) + Convert.ToString(number[0]);
        lastInFront = Convert.ToString(number[3]) + Convert.ToString(number[0]) + Convert.ToString(number[1]) + Convert.ToString(number[2]);
        exchanged = Convert.ToString(number[0]) + Convert.ToString(number[2]) + Convert.ToString(number[1]) + Convert.ToString(number[3]);
        sum = (int)Char.GetNumericValue(number[0]) + (int)Char.GetNumericValue(number[1]) + (int)Char.GetNumericValue(number[2]) + (int)Char.GetNumericValue(number[3]);

        Console.WriteLine("Number: {0}\nSum of digits: {1}\nReversed: {2}\nLast digit in front: {3}\nSecond and third digit exchanged: {4}",
            number, sum, reversed, lastInFront, exchanged);
    }
}