using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level1
{
    internal class 달리기_경주
    {
        public string[] solution(string[] players, string[] callings)
        {
            Dictionary<string, int> resultDict = new Dictionary<string, int>();

            for (int i = 0; i < players.Length; i++)
            {
                resultDict.Add(players[i], i);
            }

            for (int i = 0; i < callings.Length; i++)
            {
                int rank = resultDict[callings[i]]--;
                string name = players[rank - 1];

                players[rank - 1] = players[rank];
                players[rank] = name;

                resultDict[name]++;
            }

            return players;
        }
    }
}
