// 문제 이름 : A-B
// 
// 언어 : C#
// 
// 문제 설명 : 두 정수 A와 B를 입력받은 다음, A-B를 출력하는 프로그램을 작성하시오.
//
// 입력 : 첫째 줄에 A와 B가 주어진다. (0 < A, B < 10)
// 출력 : 첫째 줄에 A-B를 출력한다.
//
// 링크 : https://www.acmicpc.net/problem/1001
//
// ========================================================================================================================================


using System;
using System.Collections.Generic;

namespace _2750
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            List<int> list = new List<int>();
            for (int i = 0; i < input; i++) list.Add(int.Parse(Console.ReadLine()));
            list.Sort();
            foreach (int item in list) Console.WriteLine(item);
        }
    }
}
