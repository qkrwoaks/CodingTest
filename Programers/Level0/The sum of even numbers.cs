namespace Level0
{
    internal class The_sum_of_even_numbers
    {
        public int Solution(int n)
        {
            int answer = 0;
            for (int i = 0; i <= n; i++)
            {
                if (i % 2 == 0)
                    answer += i;
            }
            return answer;
        }
    }
}
