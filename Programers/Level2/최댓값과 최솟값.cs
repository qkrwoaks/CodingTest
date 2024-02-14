using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level2
{
    internal class 최댓값과_최솟값
    {
        public string solution(string s)
        {
            string[] value = s.Split(' ');

            int max = int.Parse(value[0]);

            int min = int.Parse(value[0]);

            for (int i = 1; i < value.Length; i++)
            {
                if (max > int.Parse(value[i]))
                {
                    max = int.Parse(value[i]);
                }
                if (min < int.Parse(value[i]))
                {
                    min = int.Parse(value[i]);
                }
            }

            string answer = max.ToString() + ' ' + min.ToString();

            return answer;
        }
    }
}
