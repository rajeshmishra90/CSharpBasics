using System;

namespace BasicsPractice
{
    public class Calculator
    {
        public int power(int n, int p)
        {
            int output = 1;
            if (n < 0 || p < 0)
                throw new Exception("n and p should be non-negative");
            else
            {
                for (int i = 0; i < p; i++)
                {
                    output *= n;
                }
            }

            return output;
        }
    }

    internal class MathDotPower
    {
        private static void Main2(String[] args)
        {
            Calculator myCalculator = new Calculator();
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                string[] num = Console.ReadLine().Split();
                int n = int.Parse(num[0]);
                int p = int.Parse(num[1]);
                try
                {
                    int ans = myCalculator.power(n, p);
                    Console.WriteLine(ans);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}