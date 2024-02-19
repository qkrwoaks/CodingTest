using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level1
{
    internal class 옹알이__2_
    {
        public int solution(string[] babbling)
        {
            int answer = 0;
            int except;
            string str;
            string[] check = { "aya", "ye", "woo", "ma" };
            foreach (var item in babbling)
            {
                except = -1;
                str = item;
                for (int i = 0; i < check.Length; i++)
                {
                    if (i == except)
                    {
                        continue;
                    }
                    if (str.Length < check[i].Length)
                    {
                        continue;
                    }
                    string sub = str.Substring(0, check[i].Length);
                    if (sub != check[i])
                    {
                        continue;
                    }
                    str = str.Remove(0, check[i].Length);
                    except = i;
                    i = -1;
                }
                if (str == string.Empty) answer++;
            }
            return answer;
        }
    }
}
