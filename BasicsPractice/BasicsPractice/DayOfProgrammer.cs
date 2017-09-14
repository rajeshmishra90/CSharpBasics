using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsPractice
{
    class DayOfProgrammer
    {
        static void Mainvv(String[] args)
        {
            int y = Convert.ToInt32(Console.ReadLine()); // 26.09.1918
            bool isLeapyear = false;
            if (y == 1918)
            {
                Console.WriteLine("26.09.1918");
            }
            else if (y < 1918)
            {
                if (y % 4 == 0)
                    isLeapyear = true;
            }
            else
            {
                if (y % 400 == 0)
                {
                    isLeapyear = true;
                }
                else if (y % 4 == 0 && y % 100 != 0)
                {
                    isLeapyear = true;
                }
                else
                {
                    isLeapyear = false;
                }
            }

            if (isLeapyear)
            {
                Console.WriteLine("12.09." + y);
            }
            else
            {
                Console.WriteLine("13.09." + y);
            }
        }
    }
}
