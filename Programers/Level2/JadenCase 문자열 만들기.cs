using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level2
{
    internal class JadenCase_문자열_만들기
    {
        public string solution(string s)
        {
            string answer = "";

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ')
                {
                    answer += ' ';
                }
                else if (s[i] >= 'a' && s[i] <= 'z' && i == 0 || s[i] >= 'a' && s[i] <= 'z' && i > 0 && s[i - 1] == ' ')
                {
                    answer += (char)(s[i] - 32);
                }
                else if (s[i] >= 'A' && s[i] <= 'Z' && i > 0 && s[i - 1] != ' ')
                {
                    answer += (char)(s[i] + 32);
                }
                else
                {
                    answer += s[i];
                }
            }
            return answer;
        }
    }
}
