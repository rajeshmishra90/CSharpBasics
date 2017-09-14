using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsPractice
{
    public class PracticeTest3
    {
        static int[] oddNumbers(int l, int r)
        {
            int length = r - l + 1;
            //Console.WriteLine("Length " + length);
            var resp = new List<int>();
            for (int i = l; i <= r; i++)
            {
                if (i % 2 != 0)
                {
                    resp.Add(i);
                }

            }
            return resp.ToArray();
        }

        static string findNumber(int[] arr, int k)
        {
            var index = Array.IndexOf(arr, k);
            return index >= 0 ? "YES" : "NO";

        }

        static void Main(String[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 234, 4567, 23, 45, 34534, 345345, 345345 };
            //Console.WriteLine(findNumber(arr, 10));


        }
    }
}
