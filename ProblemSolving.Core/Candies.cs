namespace ProblemSolving.Core
{
    public class Candies
    {
        public static long GetCandies(int n, List<int> arr)
        {
            int[] temp = Enumerable.Repeat(1, n).ToArray();
            while (true)
            {
                bool changed = false;
                for (int j = 1; j < n; j++)
                {
                    if (arr[j] > arr[j - 1] && temp[j - 1] >= temp[j])
                    {
                        temp[j] = temp[j - 1] + 1;
                        changed = true;
                    }

                }
                for (int j = n - 1; j > 0; j--)
                {
                    if (arr[j - 1] > arr[j] && temp[j - 1] <= temp[j])
                    {
                        temp[j - 1] = temp[j] + 1;
                        changed = true;
                    }
                }
                if (!changed) break;
            }

            return temp.Sum();
        }
    }
}
