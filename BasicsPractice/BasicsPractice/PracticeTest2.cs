using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsPractice
{
    public class PracticeTest2
    {
        static int twinArrays(int[] ar1, int[] ar2)
        {
            //if (ar1.Length == 1)
            //    return ar1[0] + ar2[0];

            int[] newar1 = (int[])ar1.Clone();
            int[] newar2 = (int[])ar2.Clone();
            Array.Sort(newar1);
            Array.Sort(newar2);
            int index1 = Array.IndexOf(ar1, newar1[0]);
            int index2 = Array.IndexOf(ar2, newar2[0]);
            if (index1 == index2)
            {
                if (newar1[1] == newar2[1])
                {
                    return newar1[0] + newar2[1];
                }
                else if (newar1[1] < newar2[1])
                    return newar1[1] + newar2[0];
                else
                    return newar1[0] + newar2[1];
            }
            else
                return newar1[0] + newar2[0];
        }

        static int patternCount(string s)
        {
            int count = 0;
            if (s.Length < 3) return count;
            int l = 1;
            while (l <= s.Length - 2)
            {
                if (s[l] == '0' && s[l - 1] == '1')
                {
                    for (int j = l + 1; j < s.Length; j++)
                    {
                        if (s[j] == '0')
                        {
                            l = j;
                        }
                        else if (s[j] == '1')
                        {
                            count++;
                            break;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                l++;
            }

            return count;

        }

        static void Main1(String[] args)
        {
            int q = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < q; a0++)
            {
                string s = Console.ReadLine();
                int result = patternCount(s);
                Console.WriteLine(result);
            }
        }

        static bool nextPermutation(char[] s)
        {
            var i = s.Length - 1;
            while (i > 0 && s[i - 1] >= s[i])
            {
                i--;
            }

            if (i <= 0)
            {
                return false;
            }

            var j = s.Length - 1;

            while (s[j] <= s[i - 1])
            {
                j--;
            }

            var temp = s[i - 1];
            s[i - 1] = s[j];
            s[j] = temp;

            j = s.Length - 1;

            while (i < j)
            {
                temp = s[i];
                s[i] = s[j];
                s[j] = temp;
                i++;
                j--;
            }

            return true;
        }

        public static int ReverseInt(int num)
        {
            int result = 0;
            while (num > 0)
            {
                result = result * 10 + num % 10;
                num /= 10;
            }
            return result;
        }
    }
}
