using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level1
{
    internal class 하샤드_수
    {
        public bool solution(int x)
        {
            bool answer = false;
            int temp = x;
            int sum = 0;

            while (x != 0)
            {
                sum += x % 10;
                x = x / 10;
            }



            answer = temp % sum == 0;

            return answer;
        }
    }
}
