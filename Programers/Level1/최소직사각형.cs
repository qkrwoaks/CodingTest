using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level1
{
    internal class 최소직사각형
    {
        public int solution(int[] A, int[] B)
        {
            int answer = 0;

            List<int> sortA = new List<int>(A);
            List<int> sortB = new List<int>(B);

            sortA.Sort();
            sortB.Sort();

            for (int i = 0; i < A.Length; i++)
            {
                answer += sortA[i] * sortB[A.Length - (i + 1)];
            }

            return answer;
        }
    }
}
