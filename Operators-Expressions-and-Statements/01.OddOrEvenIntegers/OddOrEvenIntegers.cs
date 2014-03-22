using System;

class OddOrEvenIntegers
{
    static void Main()
    {
        Console.Write("Enter integer: ");
        int number = int.Parse(Console.ReadLine());

        if(number < 0)
        {
            number *= -1;
        }

        bool odd = number % 2 == 1;

        Console.WriteLine("Odd? " + odd);
    }
}