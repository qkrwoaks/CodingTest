using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level0
{
    internal class 배열_두_배_만들기
    {
        public int[] solution(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++) numbers[i] *= 2;
            return numbers;
        }
    }
}
