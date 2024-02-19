using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level1
{
    internal class 문자열_다루기_기본
    {
        public bool solution(string s)
        {
            try
            {
                Int32.Parse(s);
            }
            catch
            {
                return false;
            }
            if (s.Length == 4 || s.Length == 6)
            {
                return false;
            }
            return true;
        }
    }
}