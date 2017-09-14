using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsPractice
{
    public class ArraySearch
    {
        public static bool Exists(int[] ints, int k)
        {
            return Array.IndexOf(ints, k) >= 0;
        }
        static void MainBS(string[] args)
        {
            int[] ints = {  };
            Console.WriteLine(Exists(ints, 0));
        }
    }
}
