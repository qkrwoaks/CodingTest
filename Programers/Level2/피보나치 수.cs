﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level2
{
    internal class 피보나치_수
    {
        public int solution(int n)
        {
            int[] fibo = new int[n + 1];
            fibo[0] = 0; fibo[1] = 1;
            for (int i = 2; i <= n; i++)
            {
                fibo[i] = fibo[i - 2] % 1234567 + fibo[i - 1] % 1234567;
            }
            return fibo[n] % 1234567;
        }
    }
}
