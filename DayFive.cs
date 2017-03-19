using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args)
    {
        int N = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= 10; i++)
        {

            Console.Write(N);
            Console.Write(" x ");
            Console.Write(i);
            Console.Write(" = ");
            Console.WriteLine(N * i);
        }
    }


}
