using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level1
{
    internal class 두_정수_사이의_합
    {
        public long solution(int a, int b)
        {
            long answer = 0;
            if (a == b)
            {
                answer = a;
            }
            else if (a < b)
            {
                for (int z = a; z < b + 1; z++)
                {
                    answer += z;
                }
            }
            else if (a > b)
            {
                for (int z = b; z < a + 1; z++)
                {
                    answer += z;
                }
            }
            return answer;
        }
    }
}
