using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level1
{
    internal class 신고_결과_받기
    {
        public int[] solution(string[] id_list, string[] report, int k)
        {
            List<User> users = new List<User>();

            foreach (var item in id_list)
            {
                users.Add(new User(item));
            }

            foreach (var item in report)
            {
                User thisUser = new User("");
                User reportedUser = new User("");

                string[] reports = item.Split(' ');

                foreach (var user in users)
                {
                    if (user.id == reports[0]) thisUser = user;
                    if (user.id == reports[1]) reportedUser = user;
                }
                if (!thisUser.reportedId.Contains(reports[1]))
                {
                    thisUser.reportedId.Add(reports[1]);
                    reportedUser.count++;
                }
            }

            foreach (var thisUser in users) if (thisUser.count >= k) foreach (var user in users) if (user.reportedId.Contains(thisUser.id)) user.resultCount++;

            List<int> answer = new List<int>();

            foreach (var user in users)
            {
                answer.Add(user.resultCount);
            }

            return answer.ToArray();
        }
    }

    public class User
    {
        public string id = "";
        public int count = 0;
        public int resultCount = 0;

        public List<string> reportedId = new List<string>();
        public List<string> stoppedId = new List<string>();

        public User(string id)
        {
            this.id = id;
        }

    }
}
