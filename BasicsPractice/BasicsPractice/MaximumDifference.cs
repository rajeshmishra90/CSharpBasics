using System;
using System.Linq;

namespace BasicsPractice
{
    internal class Difference
    {
        private int[] elements;
        public int maximumDifference;

        public Difference(int[] elems)
        {
            this.elements = elems;
        }

        public void computeDifference()
        {
            int diff = 0;
            for (int i = 0; i < elements.Length - 1; i++)
            {
                for (int j = i + 1; j < elements.Length; j++)
                {
                    diff = elements[i] - elements[j];
                    diff = Math.Abs(diff);
                    if (maximumDifference == 0 || diff > maximumDifference)
                    {
                        maximumDifference = diff;
                    }
                }
            }
        }
    }

    internal class MaximumDifference
    {
        private static void Mainc(String[] args)
        {
            Convert.ToInt32(Console.ReadLine());

            int[] a = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

            Difference d = new Difference(a);

            d.computeDifference();

            Console.Write(d.maximumDifference);
            Console.Read();
        }
    }
}