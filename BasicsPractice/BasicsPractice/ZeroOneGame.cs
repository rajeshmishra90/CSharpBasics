using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicsPractice
{
    public class ZeroOneGame
    {
        private static void Main(string[] args)
        {
            int g = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < g; a0++)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                string[] sequence_temp = Console.ReadLine().Split(' ');
                List<int> sequence = sequence_temp.Select(Int32.Parse).ToList();
                bool removed = false;
                int turn = 0;
                while (true)
                {
                    removed = RemoveTheNumber(n, sequence, removed);
                    turn++;
                    if (!removed)
                        break;
                }
                if (turn % 2 == 0)
                    Console.WriteLine("Alice");
                else
                    Console.WriteLine("Bob");
            }
        }

        private static bool RemoveTheNumber(int n, List<int> sequence, bool removed)
        {
            removed = false;
            int index = 0;
            int lastNum = sequence[0];
            int currNum = sequence[1];
            int nextNum = sequence[2];
            for (index = 1; index <= sequence.Count - 2; index++)
            {
                lastNum = sequence[index - 1];
                currNum = sequence[index];
                nextNum = sequence[index + 1];
                if (lastNum == 0 && nextNum == 0)
                {
                    sequence.RemoveAt(index);
                    removed = true;
                    break;
                }
            }

            return removed;
        }
    }
}