using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level0
{
    internal class 짝수의_합
    {
        public int solution(int n)
        {
            int answer = 0;
            for (int i = 0; i <= n; i++)
            {
                if (i % 2 == 0)
                    answer += i;
            }
            return answer;
        }
    }
}
