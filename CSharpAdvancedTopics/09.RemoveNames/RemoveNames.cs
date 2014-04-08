using System;
using System.Collections.Generic;
using System.Linq;

class RemoveNames
{
    static void Main()
    {
        string[] n = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        string[] rn = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        List<string> names = n.ToList<string>();
        List<string> removeNames = rn.ToList<string>();

        foreach (var rName in removeNames)
        {
            while(names.Contains(rName))
            {
                names.Remove(rName);
            }
        }

        foreach (var name in names)
        {
            Console.Write("{0} ", name);
        }
        Console.WriteLine();
    }
}