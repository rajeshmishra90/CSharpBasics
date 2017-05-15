using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsPractice
{
    public class JailJump
    {
        static int GetJumpCount(int input1, int input2, int[] input3)
        {
            int total = 0;
            foreach (var item in input3)
            {
                total = GetStepCount(input1, input2, total, item);
            }
            return total;
        }

        private static int GetStepCount(int input1, int input2, int total, int item)
        {
            int count = 1;
            long sum = input1;
            while (sum<item)
            {
                sum = sum + input1 - input2;
                count++;
            }
            total = total + count;
            return total;
        }

        static void MainJUmp(String[] args)
        {
            int output;
            int ip1;
            ip1 = Convert.ToInt32(Console.ReadLine());
            int ip2;
            ip2 = Convert.ToInt32(Console.ReadLine());
            int ip3_size = 0;
            ip3_size = Convert.ToInt32(Console.ReadLine());
            int[] ip3 = new int[ip3_size];
            int ip3_item;
            for (int ip3_i = 0; ip3_i < ip3_size; ip3_i++)
            {
                ip3_item = Convert.ToInt32(Console.ReadLine());
                ip3[ip3_i] = ip3_item;
            }
            output = GetJumpCount(ip1, ip2, ip3);
            Console.WriteLine(output);
        }
    }
}
