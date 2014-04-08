using System;

class NumberAsWords
{
    static void Main()
    {
        Console.WriteLine((12 / 10) % 10);

        Console.Write("Enter number (0-999): ");
        int num = int.Parse(Console.ReadLine());

        int hundreds = num / 100;
        int tens = (num / 10) % 10;
        int ones = num % 10;

        string result = "";

        string[] one = new string[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        string[] teens = new string[] { "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeeen", "eighteen", "nineteen" };
        string[] ten = new string[] { null, null, "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

        if (num >= 0 && num <= 999)
        {
            if (hundreds == 0)
            {
                if (tens == 0)
                {
                    result = one[ones];
                }
                else
                {
                    if (tens == 1)
                    {
                        result = teens[ones];
                    }
                    else
                    {
                        result = ten[tens];
                        if (ones > 0)
                        {
                            result += " " + one[ones];
                        }
                    }
                }
            }
            else
            {
                result = one[hundreds] + " hundred";
                if (tens == 0)
                {
                    if (ones != 0)
                    {
                        result += " and " + one[ones];
                    }
                }
                else
                {
                    if (tens == 1)
                    {
                        result += " and " + teens[ones];
                    }
                    else
                    {
                        result += " and " + ten[tens];
                        if (ones > 0)
                        {
                            result += " " + one[ones];
                        }
                    }
                }
            }

            Console.WriteLine(UppercaseFirst(result));
        }
        else
        {
            Console.WriteLine("number should be in 0 to 999 range");
            Main();
        }
    }

    static string UppercaseFirst(string s)
     {
	    if (string.IsNullOrEmpty(s))
	    {
	        return string.Empty;
	    }
	    return char.ToUpper(s[0]) + s.Substring(1);
    }
}