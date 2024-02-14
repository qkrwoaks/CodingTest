using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level1
{
    internal class 평균_구하기
    {
        public double solution(int[] arr)
        {
            double answer = 0;
            for (int a = 0; a < arr.GetLength(0); a++)
            {
                answer += arr[a];
            }
            answer = answer / arr.GetLength(0);
            return answer;
        }
    }
}
