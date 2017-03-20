using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(string[] args)
    {
        int number = Convert.ToInt32(Console.ReadLine());
        long fact = Factorial(number);
        Console.WriteLine(fact);
        Console.ReadKey();
    }
    //Recursive factorialing. 
    private static long Factorial(int number)
    {
        if (number == 0)
        {
            return 1;
        }
        return number * Factorial(number - 1);
    }
}