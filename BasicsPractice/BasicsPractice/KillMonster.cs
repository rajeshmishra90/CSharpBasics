using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsPractice
{
    public class KillMonster
    {
        static int getMaxMonsters(int n, int hit, int t, int[] h)
        {
            Array.Sort(h);
            int index = 0;
            for (int i = 0; i < t; i++)
            {
                h[index] = h[index] - hit;
                if (h[index] <= 0)
                    index++;
                if (index == h.Length)
                    break;
            }
            return index;
        }

        static void MainKL(string[] args)
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int hit = Convert.ToInt32(tokens_n[1]);
            int t = Convert.ToInt32(tokens_n[2]);
            string[] h_temp = Console.ReadLine().Split(' ');
            int[] h = Array.ConvertAll(h_temp, Int32.Parse);
            int result = getMaxMonsters(n, hit, t, h);
            Console.WriteLine(result);
        }
    }
}
