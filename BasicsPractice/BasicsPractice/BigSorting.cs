using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BasicsPractice
{
    public class BigSorting
    {
        static void MainBS(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            BigInteger[] unsorted = new BigInteger[n];
            for (int unsorted_i = 0; unsorted_i < n; unsorted_i++)
            {
                unsorted[unsorted_i] = BigInteger.Parse(Console.ReadLine());
            }
            // your code goes here
            Array.Sort(unsorted);
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(unsorted[i]);
            }
        }
    }
}
