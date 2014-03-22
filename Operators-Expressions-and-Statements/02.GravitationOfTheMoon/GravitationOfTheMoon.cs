using System;

class GravitationOfTheMoon
{
    static void Main()
    {
        byte gravity = 17;

        Console.Write("Enter your weight: ");
        float weight = float.Parse(Console.ReadLine());

        float moonWeight = weight * gravity / 100;
        Console.WriteLine("Your weight on the Moon is: " + moonWeight);
    }
}
