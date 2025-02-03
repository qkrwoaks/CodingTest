using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level2
{
    public class Solution
    {
        public int[] solution(int[] prices)
        {
            int[] answer = new int[prices.Length];
            for (int i = 0; i < prices.Length - 1; i++)
            {
                int count = 0;
                for (int j = i + 1; j < prices.Length; j++)
                {
                    count++;
                    if (prices[i] > prices[j])
                    {
                        break;
                    }
                }
                answer[i] = count;
            }
            answer[prices.Length - 1] = 0;
            return answer;
        }
    }

    internal class 주식가격
    {
        public static void Main()
        {
            Solution solution = new Solution();
            solution.solution(new int[] { 1, 2, 3, 2, 3 });
        }
    }
}
