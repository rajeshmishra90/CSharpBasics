using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsPractice
{
    public class CamelCase
    {
        public static void MainCC(string[] args)
        {
            string s = Console.ReadLine();
            int currIndex = 0;
            int i = 0;
            int count = 1;
            foreach (var item in s)
            {
                if (Char.IsUpper(item))
                {
                    count++;
                    //var str = s.Substring(currIndex, i- currIndex);
                    //Console.WriteLine(str);
                    currIndex = i;
                }
                i++;
            }
            Console.WriteLine(count);
        }
    }
}
