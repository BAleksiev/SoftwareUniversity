using System;

class CheckThirdDigit
{
    static void Main()
    {
        Console.Write("Enter number: ");
        string number = Console.ReadLine();

        char thirdDigit = number[number.Length - 3];

        if (thirdDigit == '7')
        {
            Console.WriteLine(true);
        }
        else
        {
            Console.WriteLine("{0}. The third digit from right to left is {1}", false, thirdDigit);
        }
    }
}