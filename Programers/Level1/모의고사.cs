using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level1
{
    internal class 모의고사
    {
        public int[] solution(int[] answers)
        {
            int[] answer = new int[] { 0, 0, 0 };
            int[] firstAnswer = new int[] { 1, 2, 3, 4, 5 };
            int[] secondAnswer = new int[] { 2, 1, 2, 3, 2, 4, 2, 5 };
            int[] thirdAnswer = new int[] { 3, 3, 1, 1, 2, 2, 4, 4, 5, 5 };
            for (int i = 0; i < answers.Length; i++)
            {
                if (firstAnswer[i % firstAnswer.Length] == answers[i]) answer[0]++;
                if (secondAnswer[i % secondAnswer.Length] == answers[i]) answer[1]++;
                if (thirdAnswer[i % thirdAnswer.Length] == answers[i]) answer[2]++;
            }
            int[] result = new int[answer.Length];
            for (int i = 0; i < answer.Length; i++)
            {
                if (answer[i] == answer.Max())
                {
                    result[i] = i + 1;
                }
                else
                {
                    result[i] = -1;
                }
            }
            return result.Except(new int[] { -1 }).ToArray();
        }
    }
}
