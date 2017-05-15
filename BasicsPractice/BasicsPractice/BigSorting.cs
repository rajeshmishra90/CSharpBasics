using System;
using System.Collections.Generic;
using System.IO;
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
            var str = File.ReadAllLines(@"C:\Users\rajeshm\Desktop\input07.txt");

            System.Diagnostics.Stopwatch watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            int n = str.Length;//Convert.ToInt32(Console.ReadLine());
            string[] unsorted = new string[n];
            for (int unsorted_i = 0; unsorted_i < n; unsorted_i++)
            {
                unsorted[unsorted_i] = str[unsorted_i];//(Console.ReadLine());
            }


            Array.Sort(unsorted, (left, right) => {
                if (left.Length != right.Length)
                {
                    return left.Length - right.Length;
                }
                else
                {
                    return string.CompareOrdinal(left, right);
                    // left.CompareTo(right) is too slow
                }
            });
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(unsorted[i]);
            }
            return;
            QuickSort.quickSortString(unsorted, 0, n - 1);


            Console.WriteLine("Sorted: ");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(unsorted[i]);
            }
            watch.Stop();
            Console.WriteLine("Watch: " + watch.ElapsedMilliseconds);
        }
    }
}
