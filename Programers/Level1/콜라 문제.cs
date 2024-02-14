using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level1
{
    internal class 콜라_문제
    {
        public int solution(int a, int b, int n)
        {
            int answer = 0;
            int remainder = 0;
            int tempNum = n;
            int temp;
            while (tempNum + remainder >= a)
            {
                temp = tempNum;
                tempNum = (temp + remainder) / a * b;
                remainder = (temp + remainder) % a;
                answer += tempNum;
            }
            return answer;
        }
    }
}
