using System;

class OddOrEvenIntegers
{
    static void Main()
    {
        int number;

        Console.WriteLine("Enter integer:");
        number = int.Parse(Console.ReadLine());

        if(number < 0)
        {
            number *= -1;
        }
        bool odd = number % 2 == 1;
        Console.WriteLine("Odd? " + odd);
    }
}