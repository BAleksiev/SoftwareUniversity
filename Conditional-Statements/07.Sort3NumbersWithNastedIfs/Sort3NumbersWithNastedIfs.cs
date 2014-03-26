using System;

class Sort3NumbersWithNastedIfs
{
    static void Main()
    {
        Console.WriteLine("Enter three numbers");
        double num1 = double.Parse(Console.ReadLine());
        double num2 = double.Parse(Console.ReadLine());
        double num3 = double.Parse(Console.ReadLine());
        
        double firstBigNum = 0.0d;
        double secondBigNum = 0.0d;
        double thirdBigNum = 0.0d;

        if(num1 >= num2 && num1 >= num3)
        {
            firstBigNum = num1;

            if(num2 <= firstBigNum && num2 >= num3)
            {
                secondBigNum = num2;
                thirdBigNum = num3;
            }
            else
            {
                secondBigNum = num3;
                thirdBigNum = num2;
            }
        }
        else if(num2 >= num1 && num2 >= num3)
        {
            firstBigNum = num2;

            if (num1 <= firstBigNum && num1 >= num3)
            {
                secondBigNum = num1;
                thirdBigNum = num3;
            }
            else
            {
                secondBigNum = num3;
                thirdBigNum = num1;
            }
        }
        else if(num3 >= num1 && num3 >= num2)
        {
            firstBigNum = num3;

            if (num2 <= firstBigNum && num2 >= num1)
            {
                secondBigNum = num2;
                thirdBigNum = num1;
            }
            else
            {
                secondBigNum = num1;
                thirdBigNum = num2;
            }
        }

        Console.WriteLine("{0}, {1}, {2}", firstBigNum, secondBigNum, thirdBigNum);
    }
}