using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsPractice
{
    public class AccurateSorting
    {
        static void MainAC(String[] args)
        {
            int q = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < q; a0++)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                string[] a_temp = Console.ReadLine().Split(' ');
                int[] a = Array.ConvertAll(a_temp, Int32.Parse);
                bool isUnSorted = false;
                for (int i = 0; i < a.Length - 1; i++)
                {
                    if (a[i] > a[i + 1] && a[i] - a[i + 1] == 1)
                    {
                        var temp = a[i];
                        a[i] = a[i + 1];
                        a[i + 1] = temp;
                    }
                }

                for (int i = 0; i < a.Length - 1; i++)
                {
                    if (a[i] > a[i + 1])
                    {
                        isUnSorted = true;
                        break;
                    }
                }
                Console.WriteLine(isUnSorted ? "No" : "Yes");
            }
        }
    }
}
