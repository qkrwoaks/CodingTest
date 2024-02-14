using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level1
{
    internal class 핸드폰_번호_가리기
    {
        public string solution(string phone_number)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < phone_number.Length - 4; i++)
            {
                sb.Append("*");
            }
            for (int i = phone_number.Length - 4; i < phone_number.Length; i++)
            {
                sb.Append(phone_number[i]);
            }
            return sb.ToString();
        }
    }
}
