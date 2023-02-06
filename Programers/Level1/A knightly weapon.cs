namespace Level1
{
    internal class A_knightly_weapon
    {
        public int Solution(int number, int limit, int power)
        {
            int count = 0;

            for (int i = 1; i <= number; i++)
            {
                int sum = CountOfDivisor(i);

                if (sum > limit)
                {
                    count += power;
                }

                else
                {
                    count += sum;
                }
            }

            return count;
        }
        private int CountOfDivisor(int num)
        {
            int divisorCount = 0;

            // 제곱근으로 계산
            for (int i = 1; i * i <= num; i++)
            {
                if (i * i == num)
                {
                    divisorCount++;
                }
                else if (num % i == 0)
                {
                    divisorCount += 2;
                }
            }

            return divisorCount;
        }
    }
}
