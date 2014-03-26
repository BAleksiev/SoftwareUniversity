using System;

class CheckPlayCard
{
    static void Main()
    {
        Console.Write("Enter playing card sign: ");
        string card = Console.ReadLine();

        string isCard = "";

        if(card == "2" || card == "3" || card == "4" || card == "5" || card == "6" || card == "7" || card == "8" || card == "9"
            || card == "10" || card == "J" || card == "Q" || card == "K" || card == "A")
        {
            isCard = "yes";
        }
        else
        {
            isCard = "no";
        }

        Console.WriteLine(isCard);
    }
}