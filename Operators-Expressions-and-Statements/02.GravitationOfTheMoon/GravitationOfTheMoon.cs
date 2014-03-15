using System;

class GravitationOfTheMoon
{
    static void Main()
    {
        byte gravity = 17;
        float weight;
        float moonWeight;

        Console.Write("Enter your weight: ");
        weight = float.Parse(Console.ReadLine());

        moonWeight = weight * gravity / 100;
        Console.WriteLine("Your weight on the Moon is: " + moonWeight);
    }
}
