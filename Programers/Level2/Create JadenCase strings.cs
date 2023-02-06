using System;

namespace Level2
{
    internal class Create_JadenCase_strings
    {
        public string solution(string s)
        {
            string[] value = s.Split(' ');

            for (int i = 0; i < value.Length; i++)
            {
                value[i] = value[i].ToUpper();
            }

            string answer = string.Concat(value);
            return answer;
        }

        public static void Main(string[] args)
        {
            Create_JadenCase_strings solution = new Create_JadenCase_strings();
            Console.WriteLine(solution.solution("3people unFollowed me"));
        }
    }
}
