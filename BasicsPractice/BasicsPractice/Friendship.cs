using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsPractice
{
    class Friendship
    {
        static void MainF(String[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < t; a0++)
            {
                string[] tokens_n = Console.ReadLine().Split(' ');
                int n = Convert.ToInt32(tokens_n[0]);
                int m = Convert.ToInt32(tokens_n[1]);
                List<int>[] students = new List<int>[n + 1];
                double totalCount = 0;
                for (int a1 = 0; a1 < m; a1++)
                {
                    string[] tokens_x = Console.ReadLine().Split(' ');
                    int x = Convert.ToInt32(tokens_x[0]);
                    int y = Convert.ToInt32(tokens_x[1]);
                    double count = 0;
                    if (students[x] == null)
                        students[x] = new List<int>();
                    if (students[y] == null)
                        students[y] = new List<int>();
                    students[x].Add(y);
                    students[y].Add(x);
                    List<int> allMutual = students[x].Union(students[y]).ToList();
                    Parallel.ForEach(allMutual, (item) =>
                    {
                        var remainF = allMutual.Where(s => s != item).ToList();
                        students[item] = remainF;
                    });

                    var list = students.Where(s => s != null && students.Count() > 0).ToList();
                    //foreach (var item in list)
                    Parallel.ForEach(list, (item) =>
                    {
                        int c = item != null ? item.Count : 0;
                        count = count + c;
                    });
                    totalCount = totalCount + count;
                }
                Console.WriteLine(totalCount);
            }
        }
    }
}
