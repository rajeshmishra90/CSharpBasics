using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsPractice
{
    public class WordPermutation
    {
        static int appearanceCount(int input1, int input2, string input3, string input4)
        {
            //4
            //11
            //cAda
            //AbrAcadAbRa
            int total = 0;
            char[] hash = new char[256];
            for (int i = 0; i < input3.Length; i++)
            {
                int index = (int)input3[i];
                hash[index] = input3[i];
            }

            for (int i = 0; i < input4.Length - input3.Length; i++)
            {
                int indexi = (int)input4[i];
                if (input4[i] == hash[indexi])
                {
                    bool found = true;
                    for (int j = 0; j < input3.Length; j++)
                    {
                        int indexj = (int)input4[i + j];
                        if (input4[i + j] != hash[indexj])
                        {
                            found = false;
                            break;
                        }
                    }
                    if (found)
                    {
                        total += 1;
                    }
                }

            }
            return total;
        }

        static void MainPEr(String[] args)
        {
            int output;
            int ip1;
            ip1 = Convert.ToInt32(Console.ReadLine());
            int ip2;
            ip2 = Convert.ToInt32(Console.ReadLine());
            string ip3;
            ip3 = Console.ReadLine();
            string ip4;
            ip4 = Console.ReadLine();
            output = appearanceCount(ip1, ip2, ip3, ip4);
            Console.WriteLine(output);
        }
    }
}
