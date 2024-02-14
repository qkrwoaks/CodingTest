using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level1
{
    internal class 수박수박수박수박수박수
    {
        public string solution(int n)
        {
            string answer = "";
            for (int z = 1; z < n + 1; z++)
            {
                if (z % 2 == 0)
                {
                    answer += '박';
                }
                else
                {
                    answer += '수';
                }
            }
            return answer;
        }
    }
}
