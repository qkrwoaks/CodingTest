using System;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(string[] id_list, string[] report, int k)
    {
        int[] answer = new int[] { };

        Data[] datas = new Data[id_list.Length];

        for (int i = 0; i < id_list.Length; i++)
        {
            datas[i].Id = id_list[i];
        }

        for (int i = 0; i < report.Length; i++)
        {
            string[] id = report[i].Split(' ');
            for (int j = 0; j < id_list.Length; j++)
            {
                if (datas[i].Id == id[0])
                {
                    datas[i].Report(id[1]);
                }
                if (datas[i].Id == id[1])
                {
                    datas[i].ReportedCount++;
                }
            }
        }

        for (int i = 0; i < id_list.Length; i++)
        {
            if (datas[i].ReportedCount > k)
            {
                answer[i]++;
                for (int j = 0; j < id_list.Length; j++)
                {
                    for (int m = 0; m < datas[i].Report_id.Count; m++)
                    {
                        if (datas[i].Id == datas[j].Report_id[m])
                        {
                            answer[j]++;
                        }
                    }
                }
            }
        }

        return answer;
    }
}

public class Data
{
    private string id;
    public string Id { get { return id; } set { id = value; } }

    private List<string> report_id = new List<string>();
    public List<string> Report_id { get { return report_id; } }

    private int reported_count;
    public int ReportedCount { get { return reported_count; } set { reported_count = value; } }

    public void Report(string report_id)
    {
        this.report_id.Add(report_id);
    }
}

public class Solution1
{
    public static void Main(string[] args)
    {
        Solution solution = new Solution();
        string[] id_list = new string[] { "muzi", "frodo", "apeach", "neo" };
        string[] report = new string[] { "muzi frodo", "apeach frodo", "frodo neo", "muzi neo", "apeach muzi" };
        int k = 2;
        Console.WriteLine(solution.solution(id_list, report, k));
    }
}
