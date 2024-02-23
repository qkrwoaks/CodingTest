using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level2
{
    internal class 이진_변환_반복하기
    {
        public int[] solution(string s)
        {
            StringBuilder exceptZero = new StringBuilder();
            string binaryNumber = string.Empty;
            int[] counts = new int[] { 0, 0 };
            while (binaryNumber != "1")
            {
                counts[0]++;
                foreach (char item in s)
                {
                    if (item.Equals('1'))
                    {
                        exceptZero.Append('1');
                    }
                    else if (item.Equals('0'))
                    {
                        counts[1]++;
                    }
                }
                binaryNumber = Convert.ToString(exceptZero.Length, 2);
                s = binaryNumber;
                exceptZero.Clear();
            }
            return counts;
        }
    }
}
