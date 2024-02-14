using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level1
{
    internal class 성격_유형_검사하기
    {
        public string solution(string[] survey, int[] choices)
        {
            string answer = "";
            int[] pt = new int[26];
            for (int i = 0; i < survey.Length; i++)
            {
                if (choices[i] < 4) pt[char.Parse(survey[i].Substring(0, 1)) - 65] += 4 - choices[i];
                else if (choices[i] > 4) pt[char.Parse(survey[i].Substring(1, 1)) - 65] += choices[i] - 4;
            }

            if (pt[17] >= pt[19]) answer += "R"; else answer += "T";
            if (pt[2] >= pt[5]) answer += "C"; else answer += "F";
            if (pt[9] >= pt[12]) answer += "J"; else answer += "M";
            if (pt[0] >= pt[13]) answer += "A"; else answer += "N";

            return answer;
        }
    }
}
