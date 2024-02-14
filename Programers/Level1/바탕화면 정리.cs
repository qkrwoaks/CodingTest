using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level1
{
    internal class 바탕화면_정리
    {
        public int[] solution(string[] wallpaper)
        {
            int[] S = new int[2] { 51, 51 };
            int[] E = new int[2] { -1, -1 };

            for (int i = 0; i < wallpaper.Length; i++)
            {
                for (int j = 0; j < wallpaper[i].Length; j++)
                {
                    if (wallpaper[i][j] == '#' && S[0] > i)
                    {
                        S[0] = i;
                    }
                    if (wallpaper[i][j] == '#' && S[1] > j)
                    {
                        S[1] = j;
                    }
                    if (wallpaper[i][j] == '#' && E[0] < i)
                    {
                        E[0] = i;
                    }
                    if (wallpaper[i][j] == '#' && E[1] < j)
                    {
                        E[1] = j;
                    }
                }
            }

            return new int[] { S[0], S[1], E[0] + 1, E[1] + 1 };
        }
    }
}
