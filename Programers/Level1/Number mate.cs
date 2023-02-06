using System;
using System.Collections.Generic;

namespace Level1
{
    internal class Number_mate
    {
        public string Solution(string X, string Y)
        {
            string answer = "";

            List<int> x = new List<int>();
            List<int> y = new List<int>();

            foreach (int item in X.ToCharArray()) x.Add(item);
            foreach (int item in Y.ToCharArray()) y.Add(item);

            x.Sort(); y.Sort();

            foreach (int xitem in x)
            {
                foreach (int yitem in y)
                {
                    if (xitem == yitem)
                    {
                        answer += xitem;
                        Console.WriteLine("xitem : " + xitem);
                        Console.WriteLine("yitem : " + yitem);
                    }
                }
            }
            if (answer == string.Empty) answer = "-1";
            return answer;
        }
    }
    class Test
    {
        public static void Main(string[] args)
        {
            Number_mate Number_mate = new Number_mate();
            Console.WriteLine(Number_mate.Solution("100", "203045"));
        }
    }
}
