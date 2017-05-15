using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsPractice
{
    public class MyGraph
    {
        private int V { get; set; }
        private List<int>[] adj;

        public MyGraph(int v)
        {
            this.V = v;
            adj = new List<int>[v];
        }

        public void AddEdge(int u, int v)
        {
            if (this.adj[u] == null) this.adj[u] = new List<int>() { v };
            else
                adj[u].Add(v);
        }

        public void BFS(int start)
        {
            bool[] visited = new bool[V];
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(start);
            visited[start] = true;

            //Queue<int> current = null;
            while (queue.Count > 0)
            {
                start = queue.Peek();
                Console.WriteLine(start);
                queue.Dequeue();

                foreach (var item in adj[start])
                {
                    if(!visited[item])
                    {
                        visited[item] = true;
                        queue.Enqueue(item);
                    }
                }
            }
        }
    }
    public class GraphBFS
    {

        static void MainG(String[] args)
        {
            MyGraph g= new MyGraph(4);
            g.AddEdge(0, 1);
            g.AddEdge(0, 2);
            g.AddEdge(1, 2);
            g.AddEdge(2, 0);
            g.AddEdge(2, 3);
            g.AddEdge(3, 3);
            Console.WriteLine("BFS: ");
            g.BFS(2);
            return;

            int cost = 6;
            int t = Convert.ToInt32(Console.ReadLine());
            while (t-- > 0)
            {
                string[] input = Console.ReadLine().Split(' ');
                int nodeCount = Convert.ToInt32(input[0]);
                int edgeCount = Convert.ToInt32(input[1]);
                List<int>[] edges = new List<int>[edgeCount];
                for (int i = 0; i < edges.Length; i++)
                {
                    string[] edge = Console.ReadLine().Split(' ');
                    int u = Convert.ToInt32(edge[0]);
                    int v = Convert.ToInt32(edge[0]);
                    if (edges[u] == null)
                        edges[u] = new List<int>() { v };
                    else
                        edges[u].Add(v);
                    if (edges[v] == null)
                        edges[v] = new List<int>() { u };
                    else
                        edges[v].Add(u);
                }
                int start = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
