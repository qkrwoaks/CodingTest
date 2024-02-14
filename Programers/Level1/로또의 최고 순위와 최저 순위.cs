using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level1
{
    internal class 로또의_최고_순위와_최저_순위
    {
        public int[] solution(int[] lottos, int[] win_nums)
        {
            int[] answer = new int[] { 0, 0 };
            int zeroCount = 0;
            for (int i = 0; i < lottos.Length; i++)
            {
                if (lottos[i] == 0)
                {
                    zeroCount++;
                    continue;
                }
                foreach (int num in win_nums)
                {
                    if (lottos[i] == num)
                    {
                        answer[1]++;
                    }
                }
            }
            if (7 - (zeroCount + answer[1]) > 6)
            {
                answer[0] = 6;
            }
            else
            {
                answer[0] = 7 - (zeroCount + answer[1]);
            }
            if (zeroCount == 6)
            {
                answer[1] = 6;
            }
            else if (7 - answer[1] > 6)
            {
                answer[1] = 6;
            }
            else
            {
                answer[1] = 7 - answer[1];
            }
            return answer;
        }
    }
}
