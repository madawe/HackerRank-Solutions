using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        double tipPercent;
        double taxPercent;
        double mealCost;
        double tip, tax, totalCost;
        mealCost = double.Parse(Console.ReadLine());
        tipPercent = double.Parse(Console.ReadLine());
        taxPercent = double.Parse(Console.ReadLine());

        tip = mealCost * ((double)tipPercent / 100);
        tax = mealCost * ((double)taxPercent / 100);
        totalCost = (mealCost + tip + tax);

        Console.Write("The total meal cost is ");
        Console.Write(Math.Round(totalCost));
        Console.Write(" dollars.");
    }
}