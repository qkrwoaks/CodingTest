using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level1
{
    internal class 약수의_합
    {
        public int solution(int n)
        {
            int b = 0;
            for (int a = 1; a < n + 1; a++)
            {
                if (n % a == 0)
                {
                    b = b + a;
                }
            }
            int answer = b;
            return answer;
        }
    }
}
