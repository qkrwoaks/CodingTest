using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level1
{
    internal class 체육복
    {
        public int solution(int n, int[] lost, int[] reserve)
        {
            int answer = 0;

            int[] list = new int[n];

            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j < lost.Length; j++)
                {
                    if (i == lost[j])
                    {
                        list[i - 1]--;
                    }
                }
                for (int j = 0; j < reserve.Length; j++)
                {
                    if (i == reserve[j])
                    {
                        list[i - 1]++;
                    }
                }
            }

            for (int i = 0; i < n; i++)
            {
                if (list[i] == -1)
                {
                    if (i == 0)
                    {
                        if (list[i + 1] == 1)
                        {
                            list[i] = 0;
                            list[i + 1] = 0;
                            i++;
                        }
                    }
                    else if (i + 1 == n)
                    {
                        if (list[i - 1] == 1)
                        {
                            list[i] = 0;
                            list[i - 1] = 0;
                        }
                    }
                    else
                    {
                        if (list[i - 1] == 1)
                        {
                            list[i] = 0;
                            list[i - 1] = 0;
                        }
                        else if (list[i + 1] == 1)
                        {
                            list[i] = 0;
                            list[i + 1] = 0;
                            i++;
                        }
                    }
                }
            }

            for (int i = 0; i < n; i++)
            {
                if (list[i] >= 0)
                {
                    answer++;
                }
            }

            return answer;
        }
    }
}
