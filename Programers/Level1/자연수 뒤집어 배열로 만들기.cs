using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level1
{
    internal class 자연수_뒤집어_배열로_만들기
    {
        public int[] solution(long n)
        {
            List<int> list = new List<int>();
            int count = (int)Math.Ceiling(Math.Log10(n));
            for (int i = 0; i < count; i++)
            {
                list.Add((int)(n % 10));
                n /= 10;
            }
            return list.ToArray();
        }
    }
}
