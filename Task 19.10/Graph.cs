using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graph
{
    class Graph
    {
        private int[,] matrix;
        private int n;
        public Graph(int[,] _matrix)
        {
            matrix = _matrix;
            n = (int)Math.Sqrt(matrix.Length);
        }
        public int FindGood(out int sum)
        {
            int min = -1;
            int num = -1;
            for (int i = 0; i < n; i ++)
            {
                int w = ways(i);
                if (min == -1 || min > w)
                {
                    min = w;
                    num = i;
                }
            }
            sum = min;
            return num;
        }
        private int ways(int num)
        {
            int[] w = new int[n];
            for (int i = 0; i < n; i++)
                w[i] = 0;
            bool[,] used = new bool[n, n];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    used[i, j] = false;
            Queue qu = new Queue();
            qu.push(num);
            while (!qu.isEmpty())
            {
                int cur = qu.pop();
                for (int i = 0; i < w.Length; i++)
                {
                    if (!used[i,cur] && matrix[cur, i] != -1)
                    {
                        if (w[i] == 0)
                            w[i] = matrix[cur, i] + w[cur];
                        else
                            if (matrix[cur, i] + w[cur] < w[i])
                            w[i] = matrix[cur, i] + w[cur];
                        qu.push(i);
                    }
                    used[cur, i] = true;
                    used[i, cur] = true;
                }
            }
            int sum = 0;
            for (int i = 0; i < n; i++)
                    sum += w[i];
            return sum;
        }
    }
}
