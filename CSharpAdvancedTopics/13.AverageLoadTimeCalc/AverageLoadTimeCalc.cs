using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Globalization;
using System.Threading;

class AverageLoadTimeCalc
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.WriteLine("Write report:");
        string report = Console.ReadLine();

        Dictionary<string, double> output = new Dictionary<string, double> { };

        while (report != string.Empty)
        {
            string[] repData = report.Split(' ');
            string site = repData[2];
            double loadTime = double.Parse(repData[3]);

            if (!output.Keys.Contains(site))
            {
                output[site] = loadTime;
            }
            else
            {
                output[site] = (output[site] + loadTime) / 2;
            }

            Console.WriteLine("Write report:");
            report = Console.ReadLine();
        }

        foreach (string site in output.Keys)
        {
            Console.WriteLine(site + " -> " + output[site]);
        }
    }
}
