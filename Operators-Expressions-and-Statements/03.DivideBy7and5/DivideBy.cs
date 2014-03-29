using System;

class DivideBy
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());

        bool isDivide = (number % 7 == 0) && (number % 5 == 0);

        if(number == 0)
        {
            isDivide = false;
        }

        Console.WriteLine("Divided by 7 and 5? {0}", isDivide);
    }
}