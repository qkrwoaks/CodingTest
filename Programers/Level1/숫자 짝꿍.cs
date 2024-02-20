using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level1
{
    internal class 숫자_짝꿍
    {
        public string solution(string X, string Y)
        {
            StringBuilder stringBuilder = new StringBuilder();

            int[] xNumberArray = new int[10] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            int[] yNumberArray = new int[10] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            foreach (int item in X)
            {
                xNumberArray[item - 48]++;
            }
            foreach (int item in Y)
            {
                yNumberArray[item - 48]++;
            }

            for (int i = xNumberArray.Length - 1; i >= 0; i--)
            {
                if (xNumberArray[i] > 0 && yNumberArray[i] > 0)
                {
                    xNumberArray[i]--;
                    yNumberArray[i]--;

                    stringBuilder.Append(i);
                    i++;
                    continue;
                }
            }

            if (stringBuilder.Equals(string.Empty))
            {
                return "-1";
            }
            else if (stringBuilder[0].Equals('0'))
            {
                return "0";
            }

            return stringBuilder.ToString();
        }
    }
}
