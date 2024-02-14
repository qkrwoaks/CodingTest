using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level1
{
    internal class 대충_만든_자판
    {
        public int[] solution(string[] keymap, string[] targets)
        {
            int[] answer = new int[targets.Length];
            int[] map = new int[26];

            foreach (var str in keymap) for (int i = 0; i < str.Length; i++) if (map[Convert.ToInt32(str[i]) - 65] > i || map[Convert.ToInt32(str[i]) - 65] == 0) map[Convert.ToInt32(str[i]) - 65] = i + 1;

            for (int i = 0; i < targets.Length; i++)
            {
                foreach (var item in targets[i])
                {
                    answer[i] += map[Convert.ToInt32(item) - 65];
                    if (map[Convert.ToInt32(item) - 65] == 0)
                    {
                        answer[i] = -1;
                        break;
                    }
                }
            }

            return answer;
        }
    }
}
