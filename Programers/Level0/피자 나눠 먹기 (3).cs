using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level0
{
    internal class 피자_나눠_먹기__3_
    {
        public int solution(int slice, int n)
        {
            return n % slice > 0 ? n / slice + 1 : n / slice;
        }
    }
}
