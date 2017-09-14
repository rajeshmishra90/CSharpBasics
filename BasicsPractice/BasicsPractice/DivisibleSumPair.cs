using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsPractice
{
    public class DivisibleSumPair
    {
        static void Maincc(String[] args)
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int k = Convert.ToInt32(tokens_n[1]);
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);
            CountMatch(a, k);
        }
        public static void CountMatch(int[] num, int k)
        {
            int count = 0;
            //store mod and such counts
            Dictionary<int, int> dict = new Dictionary<int, int>();

            foreach (int n in num)
            {
                int mod = n % k;
                int need = (k - mod) % k;

                //check if the dictionary has the balance
                if (dict.ContainsKey(need))
                {
                    count += dict[need];
                }

                //increment/add mod to dictionary
                if (dict.ContainsKey(mod))
                {
                    dict[mod] += 1;
                }
                else
                {
                    dict.Add(mod, 1);
                }
            }
            Console.WriteLine(count);
        }
    }
}
