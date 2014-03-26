using System;

class TheBiggestOf3Numbers
{
    static void Main()
    {
        Console.WriteLine("Enter three numbers: ");
        double num1 = double.Parse(Console.ReadLine());
        double num2 = double.Parse(Console.ReadLine());
        double num3 = double.Parse(Console.ReadLine());

        double biggestNumber = 0.0d;
        
        if (num1 >= num2 && num1 >= num3)
        {
            biggestNumber = num1;
        }
        else if (num2 >= num1 && num2 >= num3)
        {
            biggestNumber = num2;
        }
        else if (num3 >= num1 && num3 >= num2)
        {
            biggestNumber = num3;
        }

        Console.WriteLine("The biggest number is {0}", biggestNumber);
    }
}