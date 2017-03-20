using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        /*Even though I passed all the tests this is giving a "System.NullReferenceException: Object reference not set to an instance of an object" error. I suspect its because I am trying to read past the end of a string but I can't figure out where. I will need to ask someones advice on this when I get the chance. REMOVE ME */

        string words = "String.Empty";
        int l = 0;
        int i = Convert.ToInt32(Console.ReadLine());

        for (int k = 0; k <= i; k++)
        {
            words = Console.ReadLine();
            l = words.Length;

            //write the Even letters
            for (int j = 0; j < l; j = j + 2)
            {
                Console.Write(words[j]);
            }
            //add a space before we write the odd letters
            Console.Write(" ");
            //write the odd letters
            for (int j = 1; j < l; j = j + 2)
            {

                Console.Write(words[j]);
            }
            Console.WriteLine();
        }
    }
}