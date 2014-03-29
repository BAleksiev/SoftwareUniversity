using System;

class PrimeNumberCheck
{
    static void Main()
    {
        Console.Write("Enter positive integer number between 2 and 100: ");
        int number = int.Parse(Console.ReadLine());

        while (number < 2 || number > 100)
        {
            Console.Write("Try again: ");
            number = int.Parse(Console.ReadLine());
        }

        bool isPrime = true;
        int counter = 1;

        while (counter <= Math.Sqrt(number))
        {
            if (number % counter == 0 && counter > 1)
            {
                isPrime = false;
            }
            counter++;
        }

        Console.WriteLine(isPrime);
    }
}