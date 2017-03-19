//https://www.hackerrank.com/challenges/30-data-types
using System;
using System.Collections.Generic;
using System.IO;

class Solution{
    static void Main(String[] args)
    {
        int i = 4;
        double d = 4.0;
        string s = "HackerRank ";
        // Declare second integer, double, and String variables.

        int number;
        double anothernumber;
        string astring;

        // Read and save an integer, double, and String to your variables.


        number = Convert.ToInt32(Console.ReadLine());
        anothernumber = double.Parse(Console.ReadLine());
        astring = Console.ReadLine();
        // Print the sum of both integer variables on a new line.

        Console.WriteLine(number + i);


        // Print the sum of the double variables on a new line.
        Console.WriteLine(String.Format("{0:0.0}", anothernumber + d));


        // Concatenate and print the String variables on a new line

        Console.WriteLine(s + astring);
        // The 's' variable above should be printed first.
    }
}
