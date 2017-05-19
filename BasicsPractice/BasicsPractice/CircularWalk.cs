using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicsPractice
{
    internal class NodeN
    {
        public int Value { get; set; }

        //public int Unit { get; set; }

        public int Distance { get; set; }

        //public bool Visited { get; set; }
    }

    public class CircularWalk
    {
        private static int[] Units = null;

        private static int circularWalk(int n, int s, int t, int r_0, int g, int seed, int p)
        {
            bool[] visited = new bool[n + 1];
            Units = new int[n];
            Units[0] = r_0;
            for (int i = 1; i < n; i++)
            {
                int data = (Units[i - 1] * g + seed) % p;
                Units[i] = data;
            }

            Queue<NodeN> q = new Queue<NodeN>();
            NodeN node = new NodeN() { Value = s };
            //visited[s] = true;
            q.Enqueue(node);

            NodeN current = null;
            while (q.Count > 0)
            {
                current = q.Dequeue();
                int v = current.Value;
                int stepsRequired1 = (t < v) ? (n - 1 - v + t + 1) : t + 1;
                int stepsRequired2 = (t < v) ? v - t : v + n - t;
                int stepReq = stepsRequired1 < stepsRequired2 ? stepsRequired1 : stepsRequired2;
                if (v == t)
                    return current.Distance;
                else if (Units[v] >= stepReq)
                {
                    return current.Distance + 1;
                }
                else if (Units[v] == 0)
                    continue;

                visited[v] = true;
                int[] jump = new int[Units[v]];
                for (int c = 0; c < jump.Length; c++)
                {
                    jump[c] = c + 1;
                }

                for (int k = 0; k < jump.Length; k++)
                {
                    {
                        int antiClock = (jump[k] <= v) ? v - jump[k] : n + (v - jump[k]);
                        int clock = v + jump[k] >= n - 1 ? n - 1 - jump[k] : v + jump[k];
                        int[] options = { antiClock, clock };
                        //try
                        //{
                        NodeN newNode1 = new NodeN() { Value = options[0], Distance = current.Distance + 1 };
                        NodeN newNode2 = new NodeN() { Value = options[1], Distance = current.Distance + 1 };
                        if (visited[newNode1.Value] == false)
                        {
                            q.Enqueue(newNode1);
                            visited[newNode1.Value] = true;
                        }
                        if (visited[newNode2.Value] == false)
                        {
                            q.Enqueue(newNode2);
                            visited[newNode2.Value] = true;
                        }
                        //}
                        //catch (IndexOutOfRangeException ex)
                        //{
                        //    Console.WriteLine("Some Error");
                        //}
                    }
                }
            }

            return -1;
        }

        private static void MainCW(String[] args)
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int s = Convert.ToInt32(tokens_n[1]);
            int t = Convert.ToInt32(tokens_n[2]);
            string[] tokens_r_0 = Console.ReadLine().Split(' ');
            int r_0 = Convert.ToInt32(tokens_r_0[0]);
            int g = Convert.ToInt32(tokens_r_0[1]);
            int seed = Convert.ToInt32(tokens_r_0[2]);
            int p = Convert.ToInt32(tokens_r_0[3]);
            //try
            {
                int result = circularWalk(n, s, t, r_0, g, seed, p);
                Console.WriteLine(result);
            }
            //catch (IndexOutOfRangeException ex)
            //{
            //    Console.WriteLine("Some Error");
            //}
        }

        //private static int FollowPath(int n, int s, int t, ref int loops)
        //{
        //    loops++;
        //    int src = s;
        //    int currI = s;
        //    int dis = Units[currI];
        //    int stepsRequired1 = (t < currI) ? (n - 1 - currI + t + 1) : t + 1;
        //    int stepsRequired2 = (t < currI) ? currI - t : currI + n - t;
        //    int stepReq = stepsRequired1 < stepsRequired2 ? stepsRequired1 : stepsRequired2;
        //    if (dis >= stepReq)
        //        return 1;
        //    else if (loops >= n)
        //        return int.MinValue;
        //    int antiClock = (dis <= currI) ? currI - dis : n + (currI - dis);
        //    int[] options = { antiClock, currI + dis };
        //    int leftDis = FollowPath(n, options[0], t, ref loops) + 1;
        //    int rigtDis = FollowPath(n, options[1], t, ref loops) + 1;
        //    if (leftDis > 0 || rigtDis > 0)
        //        return leftDis < rigtDis ? leftDis : rigtDis;
        //    else return -1;
        //}
    }
}