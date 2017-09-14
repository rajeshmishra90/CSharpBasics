using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace BasicsPractice
{
    class MyStack : IDisposable
    {
        static void MainDs(string[] args)
        {
            MyStack stack = new MyStack(10000);

            Console.WriteLine("Memory Use (approx.): " + (GC.GetTotalMemory(true) / 1024) + " KBytes");

            for (int i = 0; i < 10000; i++) // fill the stack
                stack.Push("a large, large, large, large, string " + i);

            for (int i = 0; i < 10000; i++) // empty the stack
                stack.Pop();

            Console.WriteLine("Memory Use (approx.): " + (GC.GetTotalMemory(true) / 1024) + " KBytes");
        }

        // keep these two fields as they​​​​​​​​‌‌‌​‌‌​‌​‌​‌​​‌​​​‌​​‌‌ are
        private Object[] elements;
        private int size = 0;

        public MyStack(int initialCapacity)
        {
            elements = new Object[initialCapacity];
        }

        public void Push(object o)
        {
            EnsureCapacity();
            elements[size++] = o;
        }

        public object Pop()
        {
            if (size == 0)
            {
                throw new InvalidOperationException();
            }

            return elements[--size];
        }

        private void EnsureCapacity()
        {
            if (elements.Length == size)
            {
                Object[] old = elements;
                foreach (var item in elements)
                {

                }
                elements = new Object[2 * size + 1];
                old.CopyTo(elements, 0);
            }
        }

        public void Dispose()
        {
            // Free Object
        }
    }

    public class Answer
    {
        static void Mainvv(string[] args)
        {
            List<string> strings = new List<string>();
            strings.Add("hello");
            strings.Add("Load");
            strings.Add("Langer");
            strings.Add("Gabbar");
            strings.Add("LB Nagar");
            IEnumerable<string> filter = strings.Where(x => x.StartsWith("L")).OrderBy(x => x);
            var data = filter.ToList();
            return;
            Console.WriteLine(Answer.Get(4, 2)); // "6"
            Console.WriteLine(Answer.Get(5, 0)); // "1"
            Console.WriteLine(Answer.Get(67, 34)); // "14226520737620288370"
        }

        /// <returns>the number in the (l, c)​​​​​​​​‌‌‌​‌‌​‌​‌​‌​​‌​​​‌​​‌‌ cell</returns>
        public static string Get(int l, int c)
        {
            if (c == 0) return "1";
            Dictionary<string, BigInteger> stored = new Dictionary<string, BigInteger>();
            stored["00"] = 1;
            int k = 0;
            for (int i = 0; i <= k; i++)
            {
                for (int j = 0; j <= k; j++)
                {
                    if (j == 0)
                    {
                        stored[i.ToString() + j.ToString()] = 1;
                    }
                    else
                    {
                        if (j == k)
                            stored[i.ToString() + j.ToString()] = 1;
                        else
                            stored[i.ToString() + j.ToString()] = stored[(i - 1).ToString() + (j - 1).ToString()] + stored[(i - 1).ToString() + (j).ToString()];
                    }
                }
                if (k == l) break;
                k++;
            }

            return stored[l.ToString() + c.ToString()].ToString();
        }
    }
}
