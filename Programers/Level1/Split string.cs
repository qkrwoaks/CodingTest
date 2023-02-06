namespace Level1
{
    internal class Split_string
    {
        public int Solution(string s)
        {
            int answer = 0;
            int count = 0;
            int otherCount = 0;

            char? x = null;

            foreach (char item in s)
            {
                if (x == null)
                {
                    x = item;
                    count++;
                }
                else if (x != item) otherCount++;
                else count++;

                if (count == otherCount)
                {
                    answer++;
                    count = 0;
                    otherCount = 0;
                    x = null;
                }
            }

            if (x != null) answer++;

            return answer;
        }
    }
}
