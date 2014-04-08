using System;

class PrintDeckOfCards
{
    static void Main()
    {
        char[] symbols = { '♣', '♦', '♥', '♠' };
        string[] cards = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };

        for (int i = 0; i < cards.Length; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                    Console.Write("{0}{1} ", cards[i], symbols[j]);
            }
            Console.WriteLine();
        }
    }
}