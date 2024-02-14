using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level1
{
    internal class 햄버거_만들기
    {
        public int solution(int[] ingredient)
        {
            int count = 0;
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < ingredient.Length; ++i)
            {
                stack.Push(ingredient[i]);

                if (stack.Count < 4) continue;

                if (stack.ElementAt(0) == 1
                    && stack.ElementAt(1) == 3
                    && stack.ElementAt(2) == 2
                    && stack.ElementAt(3) == 1)
                {
                    for (int j = 0; j < 4; ++j)
                    {
                        stack.Pop();
                    }
                    count++;
                }
            }

            return count;
        }
    }
}
