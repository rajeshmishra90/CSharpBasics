using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsPractice
{
    public class Duplication
    {
        static string CoreString = null;

        static string duplication(int x)
        {
            return CoreString[x].ToString();
        }

        static void MainDU(string[] args)
        {
            int q = Convert.ToInt32(Console.ReadLine());
            CoreString = "";
            PrepareBinaryString();

            for (int a0 = 0; a0 < q; a0++)
            {
                int x = Convert.ToInt32(Console.ReadLine());
                string result = duplication(x);
                Console.WriteLine(result);
            }
        }

        private static void PrepareBinaryString()
        {
            string sInit = "0";
            string tInit = "1";
            CoreString = (sInit + tInit);
            while (CoreString.Length <= 1000)
            {
                sInit = CoreString;
                tInit = CoreString;
                tInit = tInit.Replace('1', 'x').Replace('0', '1').Replace('x', '0');
                //tInit = tInit.Replace('0', '1');
                //tInit = tInit.Replace('x', '0');
                CoreString = sInit + tInit;
                //Console.WriteLine(CoreString);
            }
        }
    }
}
