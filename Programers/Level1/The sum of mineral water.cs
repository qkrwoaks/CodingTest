namespace Level1
{
    internal class The_sum_of_mineral_water
    {
        public int Solution(int n)
        {
            int b = 0;
            for (int a = 1; a < n + 1; a++)
            {
                if (n % a == 0)
                {
                    b += a;
                }
            }
            int answer = b;
            return answer;
        }
    }
}
