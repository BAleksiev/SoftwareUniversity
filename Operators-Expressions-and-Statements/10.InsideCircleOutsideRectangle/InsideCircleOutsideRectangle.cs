using System;

class InsideCircleOutsideRectangle
{
    static void Main()
    {
        float circleRadius = 1.5f;
        int centerX = 1;
        int centerY = 1;
        int rectangleTop = 1;
        int rectangleLeft = -1;
        int rectangleWidth = 6;
        int rectangleHeight = 2;

        Console.Write("Enter coordinate X: ");
        float x = float.Parse(Console.ReadLine());

        Console.Write("Enter coordinate Y: ");
        float y = float.Parse(Console.ReadLine());

        bool insideCircle = Math.Pow((x - centerX), 2) + Math.Pow((y - centerX), 2) <= Math.Pow(circleRadius, 2);
        bool outsideRectangle = x >= rectangleLeft && x <= (rectangleLeft + rectangleWidth) && y <= rectangleTop && y >= (rectangleTop - rectangleHeight);

        Console.WriteLine(insideCircle);
    }
}