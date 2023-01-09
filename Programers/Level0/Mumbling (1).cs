using System;

namespace Level0
{
    internal class Mumbling__1_
    {
        public int Solution(string[] babbling)
        {
            int answer = 0;
            int len = 0;
            string[] check = { "aya", "ye", "woo", "ma" };

            foreach (string item in babbling)
            {
                for (int i = 0; i < 4; i++)
                {
                    if (item.Contains(check[i]))
                    {
                        Console.WriteLine(item);
                        len += check[i].Length;
                        if (len == item.Length)
                        {
                            answer++;
                        }
                    }
                }
                len = 0;
            }
            return answer;
        }
    }
}
