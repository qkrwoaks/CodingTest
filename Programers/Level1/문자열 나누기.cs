using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level1
{
    internal class 문자열_나누기
    {
        public int solution(string s)
        {
            int answer = 0;
            int count = 0;
            int otherCount = 0;

            char? x = null;

            foreach (char item in s)
            {
                if (x == null)
                {
                    x = item;
                    count++;
                }
                else if (x != item) otherCount++;
                else count++;

                if (count == otherCount)
                {
                    answer++;
                    count = 0;
                    otherCount = 0;
                    x = null;
                }
            }

            if (x != null) answer++;

            return answer;
        }
    }
}
