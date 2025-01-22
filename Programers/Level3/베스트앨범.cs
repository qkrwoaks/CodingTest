using System;
using System.Collections.Generic;
using System.Linq;

namespace Level3
{
    internal class 베스트앨범
    {
        public class Solution
        {
            public int[] solution(string[] genres, int[] plays)
            {
                List<int> answer = new List<int>();
                Dictionary<string, int> playDic = new Dictionary<string, int>();
                for (int count = 0; count < genres.Length; count++)
                {
                    if (playDic.ContainsKey(genres[count]))
                    {
                        playDic[genres[count]] += plays[count];
                    }
                    else
                    {
                        playDic.Add(genres[count], plays[count]);
                    }
                }

                foreach (string genre in playDic.OrderByDescending(d => d.Value).Select(d => d.Key))
                {
                    answer.AddRange(genres
                        .Select((value, index) => new { value, index })
                        .Where(item => item.value == genre)
                        .Select(item => item.index)
                        .OrderByDescending(d => plays[d])
                        .Take(2)
                        .ToArray());
                }

                return answer.ToArray();
            }
        }
    }
}
