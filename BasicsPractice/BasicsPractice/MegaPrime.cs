using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsPractice
{
    public class MegaPrime
    {
        static void MainMp(String[] args)
        {

            System.Diagnostics.Stopwatch watch = new System.Diagnostics.Stopwatch();
            watch.Start();

            Dictionary<long, bool> primeDigits = new Dictionary<long, bool>();
            primeDigits.Add(0, false);
            primeDigits.Add(1, false);
            primeDigits.Add(2, true);
            primeDigits.Add(3, true);
            primeDigits.Add(4, false);
            primeDigits.Add(5, true);
            primeDigits.Add(6, false);
            primeDigits.Add(7, true);
            primeDigits.Add(8, false);
            primeDigits.Add(9, false);

            string[] tokens_first = Console.ReadLine().Split(' ');
            long first = Convert.ToInt64(tokens_first[0]);
            long last = Convert.ToInt64(tokens_first[1]);
            long count = 0;
            for (long i = first; i <= last; i++)
            {
                bool isPrime = false;
                if (i == 1)
                    continue;
                else if (i == 2)
                    isPrime = true;
                else if (i % 2 == 0)
                    continue;

                isPrime = CheckPrime(i);
                if (isPrime)
                {
                    if (i > 10)
                    {
                        List<long> digits = NumbersIn(i); //digitArr(i);
                        foreach (var item in digits)
                        {
                            isPrime = primeDigits[item];//CheckPrime(item);
                            if (isPrime == false)
                                break;
                        }
                    }
                }
                if (isPrime)
                {
                    //Console.WriteLine(i);
                    count++;
                }
            }
            Console.WriteLine(count);
            watch.Stop();
            Console.WriteLine(watch.Elapsed.TotalSeconds);
        }

        public static List<long> NumbersIn(long value)
        {
            if (value == 0) return new List<long>();

            var numbers = NumbersIn(value / 10);

            numbers.Add(value % 10);

            return numbers;
        }

        public static long[] digitArr(long n)
        {
            if (n == 0) return new long[1] { 0 };

            var digits = new List<long>();

            for (; n != 0; n /= 10)
                digits.Add(n % 10);

            var arr = digits.ToArray();
            Array.Reverse(arr);
            return arr;
        }

        public static bool CheckPrime(long num)
        {
            bool isPrime = true;
            if (num == 1 || num == 0)
                isPrime = false;
            else if (num == 2)
                isPrime = true;
            else if (num % 2 == 0)
                isPrime = false;

            for (long i = 3; i <= Math.Sqrt(num); i += 2)
            {
                if (num % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            return isPrime;
        }
    }
}
