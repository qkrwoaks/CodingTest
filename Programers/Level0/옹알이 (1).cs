using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level0
{
    internal class 옹알이__1_
    {
        public int solution(string[] babbling)
        {
            int answer = 0;

            string str = "";
            string[] check = { "aya", "ye", "woo", "ma" };
            foreach (var item in babbling)
            {
                str = item;
                for (int i = 0; i < 4; i++)
                {
                    str = str.Replace(check[i], string.Empty);
                }
                if (str == string.Empty) answer++;
            }
            return answer;
        }
    }
}
