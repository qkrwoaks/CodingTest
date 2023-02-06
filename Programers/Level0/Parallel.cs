namespace Level1
{
    internal class Parallel
    {
        public int Solution(int[,] dots)
        {
            return (float)(dots[1, 1] - dots[0, 1]) / (float)(dots[1, 0] - dots[0, 0]) == (float)(dots[3, 1] - dots[2, 1]) / (float)(dots[3, 0] - dots[2, 0]) || (float)(dots[2, 1] - dots[0, 1]) / (float)(dots[2, 0] - dots[0, 0]) == (float)(dots[3, 1] - dots[1, 1]) / (float)(dots[3, 0] - dots[1, 0]) ? 1 : 0;
        }
    }
}
