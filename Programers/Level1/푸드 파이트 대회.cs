using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level1
{
    internal class 푸드_파이트_대회
    {
        public string solution(int[] food)
        {
            string answer = "";
            int count = 1;
            while (food.Length != count)
            {
                for (int i = 0; i < food[count] / 2; i++) answer += count.ToString();
                count++;
            }
            answer += "0";
            count--;
            while (count != 0)
            {
                for (int i = 0; i < food[count] / 2; i++) answer += count.ToString();
                count--;
            }
            return answer;
        }
    }
}
