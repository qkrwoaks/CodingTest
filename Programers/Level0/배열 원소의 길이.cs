using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level0
{
    internal class 배열_원소의_길이
    {
        public int[] solution(string[] strlist)
        {
            List<int> list = new List<int>();
            foreach (var item in strlist) list.Add(item.Length);
            return list.ToArray();
        }
    }
}
