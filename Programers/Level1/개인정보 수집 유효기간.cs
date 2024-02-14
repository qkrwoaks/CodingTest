using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level1
{
    internal class 개인정보_수집_유효기간
    {
        public class Solution
        {
            public int[] solution(string today, string[] terms, string[] privacies)
            {
                List<int> answer = new List<int>();

                Day toDay = new Day(today);

                List<Terms> termsList = new List<Terms>();

                foreach (var item in terms) termsList.Add(new Terms(item));

                int i = 0;

                foreach (var item in privacies)
                {
                    i++;
                    string[] split = item.Split();

                    Day day = new Day(split[0]);

                    foreach (var term in termsList) if (term.name.Equals(split[1])) day.AddMonth(term.time_limit);
                    if (((day.year * 12) + day.month) * 28 + day.day <= ((toDay.year * 12) + toDay.month) * 28 + toDay.day) answer.Add(i);

                }

                return answer.ToArray();
            }
        }

        public class Day
        {
            public int year;
            public int month;
            public int day;

            public Day(string str)
            {
                string[] split = str.Split('.');
                year = int.Parse(split[0]);
                month = int.Parse(split[1]);
                day = int.Parse(split[2]);
            }

            public void AddMonth(int monthValue)
            {
                month += monthValue;
                if (month > 12)
                {
                    month -= 12;
                    year++;
                }
            }
        }

        public class Terms
        {
            public string name;
            public int time_limit;

            public Terms(string str)
            {
                string[] split = str.Split(' ');
                name = split[0];
                time_limit = int.Parse(split[1]);
            }
        }
    }
}
