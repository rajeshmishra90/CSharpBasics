using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsPractice
{
    class Sockmerchant
    {
        static void MainNN(String[] args)
        {
            
            int n = Convert.ToInt32(Console.ReadLine());
            string[] c_temp = Console.ReadLine().Split(' ');
            int[] c = Array.ConvertAll(c_temp, Int32.Parse);
            //var numbers = c_temp.Select(Int32.Parse).ToList();
            Array.Sort(c);
            int count = 0;
            for (int i = 0; i < c.Length; i++)
            {
                for (int j = i + 1; j < c.Length; j++)
                {
                    if (c[j] > c[i])
                        break;
                    if (c[i] == c[j] && c[i] != 0)
                    {
                        count = count + 1;
                        c[i] = 0;
                        c[j] = 0;
                    }
                }
            }
            Console.WriteLine(count);
            Console.Read();
        }
    }
}
