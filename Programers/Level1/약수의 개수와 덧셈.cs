using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level1
{
    internal class 약수의_개수와_덧셈
    {
        public int solution(int left, int right)
        {
            int answer = 0;
            for (int i = left; i <= right; i++)
            {
                if (CountOnDivisor(i) % 2 == 0)
                {
                    answer += i;
                }
                else
                {
                    answer -= i;
                }
            }
            return answer;
        }

        private int CountOnDivisor(int left)
        {
            int count = 1;
            for (int i = 1; i <= left / 2; i++)
            {
                if (left % i == 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
