using System;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();
        string[] array = new string[] { "wooyemawooye", "mayaa", "ymaeaya" };
        Console.WriteLine(solution.solution(array));
    }
}

public class Solution
{
    public int solution(string[] babbling)
    {
        int answer = 0;
        int len;
        string[] check = { "aya", "ye", "woo", "ma" };
        string laststr;
        int lastTemp;

        foreach (string item in babbling)
        {
            len = 0;
            lastTemp = -1;
            laststr = string.Empty;
            for (int i = 0; i < 4; i++)
            {
                if (item.Contains(check[i])) // 옹알이를 했을 때
                {
                    if (laststr != check[i] && lastTemp != item.IndexOf(check[i], 0, item.Length) + check[i].Length - 1) // 연속되지 않을 때
                    {
                        Console.WriteLine(check[i]);
                        lastTemp = item.IndexOf(check[i], 0, item.Length);
                        laststr = check[i];
                        len += check[i].Length;
                        if (len == item.Length)
                        {
                            answer++;
                        }
                        else
                        {
                            i = 0;
                            continue;

                        }
                    }
                }
            }
        }

        return answer;
    }
}


//public class Solution
//{
//    public int solution(string[] babbling)
//    {
//        int answer = 0;
//        int count = 0;
//        string[] check = { "aya", "ye", "woo", "ma" };
//        string strTemp;
//        string laststr;

//        foreach (string item in babbling)
//        {
//            strTemp = item;
//            laststr = string.Empty;
//        Restart:
//            foreach (string str in check)
//            {
//                if (strTemp.Contains(str) && laststr != str)
//                {
//                    laststr = str;
//                    count += str.Length;
//                    if (count == item.Length || strTemp == str)
//                    {
//                        answer++;
//                    }
//                    else
//                    {
//                        int posTemp = strTemp.IndexOf(str, 0, strTemp.Length);
//                        strTemp = strTemp.Remove(posTemp, str.Length);
//                        goto Restart;
//                    }
//                }
//                else if (laststr == str)
//                {
//                    laststr = string.Empty;
//                }
//            }
//            count = 0;
//        }
//        return answer;
//    }
//}
