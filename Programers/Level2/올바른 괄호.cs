using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level2
{
    internal class 올바른_괄호
    {
        public bool solution(string s)
        {
            Stack<char> stack = new Stack<char>();
            try
            {
                foreach (char item in s)
                {
                    if (item.Equals('('))
                    {
                        stack.Push('s');
                    }
                    else if (item.Equals(')'))
                    {
                        stack.Pop();
                    }
                }
            }
            catch
            {
                return false;
            }
            if (stack.Count == 0)
            {
                return true;
            }
            return false;
        }
    }
}
