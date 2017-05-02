using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace BasicsPractice
{
    class Permutations
    {
        private static void Swap(ref char a, ref char b)
        {
            if (a == b) return;

            a ^= b;
            b ^= a;
            a ^= b;
        }

        public static void GetPer(char[] list)
        {
            int x = list.Length - 1;
            GetPer(list, 0, x);
        }

        private static void GetPer(char[] list, int k, int m)
        {
            if (k == m)
            {
                Console.WriteLine(list);
            }
            else
                for (int i = k; i <= m; i++)
                {
                    Swap(ref list[k], ref list[i]);
                    GetPer(list, k + 1, m);
                    Swap(ref list[k], ref list[i]);
                }
        }

        static void Main9()
        {
            try
            {
                int n = Convert.ToInt32(Console.ReadLine());
                string number = "91389681247993671255432112000000";// Console.ReadLine();
                int len = number.Length;
                //if (len > 10)
                //    return;
                var results =
                    (from e in Enumerable.Range(0, 1 << len)
                     let p =
                         from b in Enumerable.Range(0, len)
                         select (e & (1 << b)) == 0 ? (char?)null : number[b]
                     select string.Join(string.Empty, p));
                BigInteger x = 0;
                var intList = results.Where(p => BigInteger.TryParse(p, out x))
                            .Select(p => x).Where(l => l == 0 || l % 8 == 0).ToList();
                Console.WriteLine((intList.Count) % (1000000007));
            }
            catch (TimeoutException)
            {
                Console.WriteLine("Timeout");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            Console.ReadLine();

            //-------------------------------
            //string str = "123";
            //char[] arr = str.ToCharArray();
            //GetPer(arr);
        }

        public static string[] Combination2(string str)
        {
            List<string> output = new List<string>();
            // Working buffer to build new sub-strings
            char[] buffer = new char[str.Length];

            Combination2Recurse(str.ToCharArray(), 0, buffer, 0, output);

            return output.ToArray();
        }

        public static void Combination2Recurse(char[] input, int inputPos, char[] buffer, int bufferPos, List<string> output)
        {
            if (inputPos >= input.Length)
            {
                // Add only non-empty strings
                if (bufferPos > 0)
                    output.Add(new string(buffer, 0, bufferPos));

                return;
            }

            // Recurse 2 times - one time without adding current input char, one time with.
            Combination2Recurse(input, inputPos + 1, buffer, bufferPos, output);

            buffer[bufferPos] = input[inputPos];
            Combination2Recurse(input, inputPos + 1, buffer, bufferPos + 1, output);
        }
    }
}
