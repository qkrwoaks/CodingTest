using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level0
{
    internal class 컨트롤_제트
    {
        public int solution(string s)
        {
            int answer = 0;
            string[] listString = s.Split(' ');

            int[] listNum = new int[listString.Length];

            for (int i = 0; i < listString.Length; i++)
            {
                if (listString[i] == "Z")
                {
                    answer -= listNum[i - 1];
                    continue;
                }
                listNum[i] = Int32.Parse(listString[i]);

                answer += listNum[i];
            }

            return answer;
        }
    }
}
