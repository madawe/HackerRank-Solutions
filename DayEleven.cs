using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static void Main(String[] args)
    {
        int[][] arr = new int[6][];
        for (int arr_i = 0; arr_i < 6; arr_i++)
        {
            string[] arr_temp = Console.ReadLine().Split(' ');
            arr[arr_i] = Array.ConvertAll(arr_temp, Int32.Parse);
        }

        //my code starts here. // its [row] then [column]
        //The for loop is only going to go through all the locations that correspond to the top center of the vase.

        int temp = 0;
        int winner = -65534;

        for (int row = 0, column = 1; row < 4; column++)
        {

            //Console.WriteLine(arr[row][column]);

            temp = ((arr[row][column - 1]) + (arr[row][column]) + (arr[row][column + 1]) +
                                        (arr[row + 1][column]) +
                (arr[row + 2][column - 1]) + (arr[row + 2][column]) + (arr[row + 2][column + 1]));
            //Console.WriteLine(temp);

            if (temp >= winner)
            {
                winner = temp;
            }

            if (column == 4)
            {
                row++;
                column = 0;
                //Console.WriteLine("Column hit 4" + row + column);
            }

        }
        Console.WriteLine(winner);

    }
}