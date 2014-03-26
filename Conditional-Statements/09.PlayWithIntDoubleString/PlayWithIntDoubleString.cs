using System;

class PlayWithIntDoubleString
{
    static void Main()
    {
        Console.WriteLine("Please choose a type: \n 1 --> int \n 2 --> double \n 3 --> string");
        int choice = int.Parse(Console.ReadLine());

        switch(choice)
        {
            case 1:
                Console.Write("Please enter a integer: ");
                int intInput = int.Parse(Console.ReadLine());
                Console.WriteLine(intInput + 1);
                break;
            case 2:
                Console.Write("Please enter a double: ");
                double doubleInput = double.Parse(Console.ReadLine());
                Console.WriteLine(doubleInput + 1.0);
                break;
            case 3:
                Console.Write("Please enter a string: ");
                string stringInput = Console.ReadLine();
                Console.WriteLine("{0}*", stringInput);
                break;
        }
    }
}