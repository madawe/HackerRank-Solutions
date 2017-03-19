using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static void Main(String[] args)
    {
        int N = Convert.ToInt32(Console.ReadLine());
        bool done = false;
        // I decieded to just test for the Not Weird situations, if they don't test true it must be Weird.
        if (N % 2 == 0 && N > 20)
        {
            Console.WriteLine("Not Weird");
            done = true;
        }
        if (N % 2 == 0 && N < 6)
        {
            Console.WriteLine("Not Weird");
            done = true;
        }
        if (done != true)
        {
            Console.WriteLine("Weird");
        }


    }
}