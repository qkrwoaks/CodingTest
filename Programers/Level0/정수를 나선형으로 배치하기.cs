using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level0
{
    internal class 정수를_나선형으로_배치하기
    {
        public int[,] solution(int n)
        {
            int[,] answer = new int[n, n];
            int count = 1;
            for (int i = 0, j = 0, k = 0; n * n >= count; i++)
            {
                if (n * n == count)
                {
                    answer[i, i] = count;
                    break;
                }
                for (j = i, k = i; j < n - 1 - i; j++)
                {
                    answer[k, j] = count++;
                }
                for (; k < n - 1 - i; k++)
                {
                    answer[k, j] = count++;
                }
                for (; j > i; j--)
                {
                    answer[k, j] = count++;
                }
                for (; k > i; k--)
                {
                    answer[k, j] = count++;
                }
            }
            return answer;
        }
    }
}