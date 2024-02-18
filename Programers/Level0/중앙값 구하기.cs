using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level0
{
    internal class 중앙값_구하기
    {
        public int solution(int[] array)
        {
            List<int> list = new List<int>(array);
            list.Sort();
            return list[list.Count / 2];
        }
    }
}
