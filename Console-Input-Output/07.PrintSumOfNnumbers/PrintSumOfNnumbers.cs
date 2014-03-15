using System;

class PrintSumOfNnumbers
{
    static void Main()
    {
        int sum = 0;
        int num = 0;
        string str = "";

        Console.Write("How many numbers will sum? ");
        int n = int.Parse(Console.ReadLine());
        
        for(int i = 1; i <= n; i++)
        {
            Console.Write("Enter number {0}: ", i);
            num = int.Parse(Console.ReadLine());
            sum += num;
            str += Convert.ToString(num);
            if (i < n)
            {
                str += " + ";
            }
            else
            {
                str += " = ";
            }
        }
        Console.Write(str + sum + "\n");
    }
}