using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level1
{
    internal class 둘만의_암호
    {
        public string solution(string s, string skip, int index)
        {
            string answer = "";

            string alpa = "";

            for (int i = 0; i < 3; i++) for (int j = 0; j < 26; j++) if (skip.IndexOf((char)(j + 97)) == -1) alpa += (char)(j + 97);

            for (int i = 0; i < s.Length; i++)
            {
                answer += alpa[alpa.IndexOf(s[i]) + index];
            }

            return answer;
        }

    }
}
