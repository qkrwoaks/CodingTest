using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level0
{
    internal class 주사위의_개수
    {
        public int solution(int[] box, int n)
        {
            return (box[0] / n) * (box[1] / n) * (box[2] / n);
        }
    }
}
