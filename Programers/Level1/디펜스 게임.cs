using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level1
{
    internal class 디펜스_게임
    {
        public class Solution
        {
            public int solution(int n, int k, int[] enemy)
            {
                int answer = k;

                if (enemy.Length <= k) return enemy.Length;

                MinHeap god = new MinHeap();

                for (int i = 0; i < k; i++) god.Add(enemy[i]);

                int minenemy = god.RemoveOne();

                for (int i = k; i < enemy.Length; i++)
                {
                    if (minenemy < enemy[i])
                    {
                        n -= minenemy;
                        god.Add(enemy[i]);
                        minenemy = god.RemoveOne();
                    }
                    else n -= enemy[i];
                    if (n < 0) break;
                    answer++;
                }

                return answer;
            }
        }
        public class MinHeap
        {
            private List<int> A = new List<int>();

            public void Add(int value)
            {
                // add at the end
                A.Add(value);

                // bubble up
                int i = A.Count - 1;
                while (i > 0)
                {
                    int parent = (i - 1) / 2;
                    if (A[parent] > A[i]) // MinHeap에선 반대
                    {
                        Swap(parent, i);
                        i = parent;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            public int RemoveOne()
            {
                if (A.Count == 0)
                    throw new InvalidOperationException();

                int root = A[0];

                // move last to first 
                // and remove last one
                A[0] = A[A.Count - 1];
                A.RemoveAt(A.Count - 1);

                // bubble down
                int i = 0;
                int last = A.Count - 1;
                while (i < last)
                {
                    // get left child index
                    int child = i * 2 + 1;

                    // use right child if it is bigger                
                    if (child < last &&
                        A[child] > A[child + 1]) // MinHeap에선 반대
                        child = child + 1;

                    // if parent is bigger or equal, stop
                    if (child > last ||
                       A[i] <= A[child]) // MinHeap에선 반대
                        break;

                    // swap parent/child
                    Swap(i, child);
                    i = child;
                }

                return root;
            }

            private void Swap(int i, int j)
            {
                int t = A[i];
                A[i] = A[j];
                A[j] = t;
            }
        }
    }
}
