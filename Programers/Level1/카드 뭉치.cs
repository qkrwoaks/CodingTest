using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level1
{
    internal class 카드_뭉치
    {
        public string solution(string[] cards1, string[] cards2, string[] goal)
        {
            Queue<string> card1 = new Queue<string>(cards1);
            Queue<string> card2 = new Queue<string>(cards2);
            Queue<string> goals = new Queue<string>(goal);

            while (goals.Count > 0)
            {
                if (card1.Count > 0 && card1.Peek().Equals(goals.Peek()))
                {
                    card1.Dequeue();
                    goals.Dequeue();
                    continue;
                }
                if (card2.Count > 0 && card2.Peek().Equals(goals.Peek()))
                {
                    card2.Dequeue();
                    goals.Dequeue();
                    continue;
                }
                return "No";
            }
            return "Yes";
        }
    }
}
