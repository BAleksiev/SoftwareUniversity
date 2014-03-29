using System;

class BitExchangeAdvanced
{
    static void Main()
    {

        uint number = 0;
        int k = 0;
        do
        {
            Console.Write("Enter positive integer: ");
            number = uint.Parse(Console.ReadLine());
        } while (number <= 0);

        Console.Write("Enter position of first bits: ");
        int p = int.Parse(Console.ReadLine());
        Console.Write("Enter position of second bits: ");
        int q = int.Parse(Console.ReadLine());

        do
        {
            Console.Write("Enter how many bits you want to change: ");
            k = int.Parse(Console.ReadLine());
        } while (number <= 0);

        uint result = number;
        uint mask1 = 0;
        uint mask2 = 0;

        // If p > q - change values
        if (p > q)
        {
            p += q;
            q = p - q;
            p = p - q;
        }

        // check for out of range
        if (q + k <= 32)
        {
            // check for overlapping
            if (p + k <= q)
            {
                // If P and Q are equal, then just print the input number without doing any operations
                if (q != p)
                {
                    for (int i = 0; i < k; i++)
                    {
                        mask1 <<= 1;
                        mask1 |= 1;
                    }

                    mask2 = mask1;
                    mask1 <<= p;
                    mask2 <<= q;

                    uint bitsPos1 = number & mask1;
                    uint bitsPos2 = number & mask2;

                    bitsPos1 <<= q - p;
                    bitsPos2 >>= q - p;

                    result &= ~mask1;
                    result &= ~mask2;

                    result |= bitsPos1;
                    result |= bitsPos2;
                }
                Console.WriteLine("Result: {0}", result);
            }
            else
            {
                Console.WriteLine("overlapping");
            }
        }
        else
        {
            Console.WriteLine("out of range");
        }
    }
}
