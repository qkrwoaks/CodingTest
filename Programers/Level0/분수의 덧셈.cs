using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level0
{
    internal class 분수의_덧셈
    {
        public int[] solution(int numer1, int denom1, int numer2, int denom2)
        {
            int[] answer = new int[] { };

            int number, demon;

            if (denom1 > denom2 && denom1 % denom2 == 0)
            {
                number = numer2 * (denom1 / denom2) + numer1;
                demon = denom1;
            }
            else if (denom2 > denom1 && denom2 % denom1 == 0)
            {
                number = numer1 * (denom2 / denom1) + numer2;
                demon = denom2;
            }
            else
            {
                number = numer1 * denom2 + numer2 * denom1;
                demon = denom1 * denom2;
            }

            if (number == demon)
            {
                answer = new int[] { 1, 1 };
            }
            else if (number >= 2 && demon >= 2)
            {
                int i;
                for (i = demon; ; i--)
                {
                    if (number % i == 0 && demon % i == 0)
                    {
                        answer = new int[] { number / i, demon / i };
                        break;
                    }
                }
            }
            else
            {
                answer = new int[] { number, demon };
            }

            return answer;
        }
    }
}
