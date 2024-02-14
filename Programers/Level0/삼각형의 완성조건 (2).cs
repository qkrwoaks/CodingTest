using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level0
{
    internal class 삼각형의_완성조건__2_
    {
        public int solution(int[] sides)
        {
            int answer = 0;

            int bigNum;
            int smallNum;

            if (sides[0] > sides[1])
            {
                bigNum = sides[0];
                smallNum = sides[1];
            }
            else
            {
                bigNum = sides[1];
                smallNum = sides[0];
            }

            for (int i = 1; i < bigNum; i++)
            {
                if (IsTriangle(bigNum, smallNum + i))
                {
                    answer++;
                }
            }

            for (int i = bigNum; IsTriangle(i, smallNum + bigNum); i++)
            {
                answer++;
            }

            return answer;
        }

        private bool IsTriangle(int bigNum, int numSum) => numSum > bigNum;
    }
}
