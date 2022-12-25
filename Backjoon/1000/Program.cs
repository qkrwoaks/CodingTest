// 문제 이름 : A+B
// 
// 언어 : C#
// 
// 문제 설명 : 두 정수 A와 B를 입력받은 다음, A+B를 출력하는 프로그램을 작성하시오.
//
// 입력 : 첫째 줄에 A와 B가 주어진다. (0 < A, B < 10)
// 출력 : 첫째 줄에 A+B를 출력한다.
//
// 링크 : https://www.acmicpc.net/problem/1000
//
// ========================================================================================================================================

using System;

namespace _1000 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split(' ');
            Console.WriteLine(int.Parse(str[0]) + int.Parse(str[1]));
        }
    }
}
