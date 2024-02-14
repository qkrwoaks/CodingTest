using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level1
{
    internal class 내적
    {
        public int solution(int[] a, int[] b)
        {
            int answer = 0;
            for (int i = 0; i < a.Length; i++)
            {
                answer += a[i] * b[i];
            }
            return answer;
        }
    }
}
