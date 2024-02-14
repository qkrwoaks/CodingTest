using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level0
{
    internal class 배열의_평균값
    {
        public double solution(int[] numbers)
        {
            double answer = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                answer += numbers[i];
            }

            return answer / numbers.Length;
        }
    }
}
