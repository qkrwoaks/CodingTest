using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level0
{
    internal class 합성수_찾기
    {
        public int solution(int n)
        {
            int answer = 0;
            for (int i = 4; i <= n; i++)
            {
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        answer++;
                        break;
                    }
                }
            }
            return answer;
        }
    }
}