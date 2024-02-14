using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level1
{
    internal class 콜라츠_추측
    {
        public int solution(int num)
        {
            if (num == 1) return 0;
            return FindCollard(num, 1);
        }

        private int FindCollard(long num, int time)
        {
            if (time == 500)
            {
                return -1;
            }
            if (num % 2 == 0)
            {
                num /= 2;
            }
            else
            {
                num = num * 3 + 1;
            }
            if (num == 1)
            {
                return time;
            }
            return FindCollard(num, time + 1);
        }
    }
}
