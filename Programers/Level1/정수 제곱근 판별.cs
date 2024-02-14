using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level1
{
    internal class 정수_제곱근_판별
    {
        public long solution(long n)
        {
            double sqr = Math.Sqrt(n);
            if (Math.Floor(sqr) == sqr)
            {
                return (long)Math.Pow(sqr + 1, 2);
            }
            return -1;
        }
    }
}
