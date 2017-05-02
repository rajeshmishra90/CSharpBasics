using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsPractice
{
    class PrintPattern
    {
        public static void MainPr(string[] args)
        {
            int count = 5;
            for (int i = 0; i < count; i++)
            {
                for (int j = count - 1 - i; j > 0; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k <= i; k++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
        }
    }
}
