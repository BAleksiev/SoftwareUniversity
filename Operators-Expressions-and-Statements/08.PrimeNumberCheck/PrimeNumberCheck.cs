using System;

class PrimeNumberCheck
{
    static void Main()
    {
        int number = 0;
        bool isPrime;

        while (number <= 0 || number > 100)
        {
            Console.Write("Enter positive integer <= 100: ");
            number = int.Parse(Console.ReadLine());
        }



        Console.WriteLine(isPrime);
        Main();
    }
}