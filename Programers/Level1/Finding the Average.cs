namespace Level1
{
    internal class Finding_the_Average
    {
        public double Solution(int[] arr)
        {
            double answer = 0;
            for (int a = 0; a < arr.GetLength(0); a++)
            {
                answer += arr[a];
            }
            answer = answer / arr.GetLength(0);
            return answer;
        }
    }
}
