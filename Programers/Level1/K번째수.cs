using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level1
{
    internal class K번째수
    {
        public int[] solution(int[] array, int[,] commands)
        {
            int[] answer = new int[commands.GetLength(0)];
            for (int i = 0; i < commands.GetLength(0); i++)
            {
                int l = commands[i, 0];
                int j = commands[i, 1];
                int k = commands[i, 2];

                int[] a = new int[j - l + 1];
                Array.Copy(array, l - 1, a, 0, j - l + 1);
                Array.Sort(a);
                answer[i] = a[k - 1];
            }
            return answer;
        }
    }
}
