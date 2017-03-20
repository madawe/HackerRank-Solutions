using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        Dictionary<string, string> phoneBook =
        new Dictionary<string, string>();

        //The number of additions to the dictionary.
        string entries;
        entries = Console.ReadLine();
        // debug code Console.WriteLine(entries);

        //creating a temp variable and an array so that I can use it outside the loop.
        string numbers = null;
        string[] keyValues = null;

        // Take the STDIN and put it into a dictionary. Split is creating an array with the value for before the space and after the space
        for (int i = 0; i < (Convert.ToInt32(entries)); i++)
        {
            numbers = Console.ReadLine();
            keyValues = numbers.Split(' ');
            phoneBook.Add(keyValues[0], keyValues[1]);
        }

        // from STDIN check the dictionary for the keys. Check to make sure the key exists before trying to write it's value.        
        for (int i = 0; i < (Convert.ToInt32(entries)); i++)
        {
            numbers = Console.ReadLine();
            keyValues = numbers.Split(' ');
            if (phoneBook.ContainsKey(keyValues[0]))
            {
                Console.WriteLine(keyValues[0] + "=" + phoneBook[keyValues[0]]);
            }
            else
            {
                Console.WriteLine("Not found");
            }
        }

        //End my Code
    }
}