using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicsPractice
{
    public class GraphNode
    {
        public int Value { get; set; }

        public int Distance { get; set; }
    }

    public class SnakeLadderGame
    {
        public static void MainSL(string[] args)
        {
            int vertices = 100;
            int t = Convert.ToInt32(Console.ReadLine());
            while (t-- > 0)
            {
                int numberOfLadders = 0;
                int numberOfSnakes = 0;
                int[] moves = Enumerable.Repeat(-1, vertices + 1).ToArray();
                numberOfLadders = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < numberOfLadders; i++)
                {
                    string[] input = Console.ReadLine().Split(' ');
                    moves[Convert.ToInt32(input[0]) - 1] = Convert.ToInt32(input[1]) - 1;
                }
                numberOfSnakes = Convert.ToInt32(Console.ReadLine());
                for (int j = 0; j < numberOfSnakes; j++)
                {
                    string[] input = Console.ReadLine().Split(' ');
                    moves[Convert.ToInt32(input[0]) - 1] = Convert.ToInt32(input[1]) - 1;
                }

                Console.WriteLine(GetMinimumDiceThrow(moves, vertices));
            }
        }

        private static int GetMinimumDiceThrow(int[] moves, int vertices)
        {
            bool[] visited = new bool[vertices];
            Queue<GraphNode> queue = new Queue<GraphNode>();

            visited[0] = true;
            GraphNode node = new GraphNode() { Distance = 0, Value = 0 };
            queue.Enqueue(node);

            GraphNode current = null;
            //if (vertices == 1)
            //return 1;
            while (queue.Count > 0)
            {
                current = queue.Peek();
                int v = current.Value;
                if (v == vertices - 1)
                {
                    return current.Distance;
                }
                queue.Dequeue();
                for (int j = v + 1; j <= (v + 6) && j < vertices; ++j)
                {
                    // If this cell is already visited, then ignore
                    if (!visited[j])
                    {
                        // Otherwise calculate its distance and mark it
                        // as visited
                        GraphNode a = new GraphNode();
                        a.Distance = (current.Distance + 1);
                        visited[j] = true;

                        // Check if there a snake or ladder at 'j'
                        // then tail of snake or top of ladder
                        // become the adjacent of 'i'
                        if (moves[j] != -1)
                            a.Value = moves[j];
                        else
                            a.Value = j;
                        queue.Enqueue(a);
                    }
                }
            }
            return -1;
        }
    }
}