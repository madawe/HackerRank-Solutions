using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());

        //my code

        string binaryN = Convert.ToString(n, 2);
        //Console.WriteLine(binaryN);

        int max = 1;
        int currentMax = 0;
        foreach (char bin in binaryN)
        {
            if (bin == '1')
            {
                currentMax = currentMax + 1;
            }
            else
            {
                if (currentMax >= max)
                {
                    max = currentMax;
                }
                currentMax = 0;
            }
        }
        if (currentMax > max)
        {
            max = currentMax;
            currentMax = 0;
        }
        Console.WriteLine(max);
        //end my code 
    }
}