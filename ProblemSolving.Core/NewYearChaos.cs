namespace ProblemSolving.Core
{
    public class NewYearChaos
    {
        public static string GetNumberOfBribes(List<int> q)
        {
            int n = q.Count;

            int x, y = 0;

            for (int j = 0; j < n; j++)
            {


                if (q[j] - j > 3)
                {
                    y = -1;
                }
            }

            if (y == -1)
            {
                return "Too chaotic";
            }

            int yr;
            for (int k = 0; k < n; k++)
            {
                yr = y;
                for (int j = 0; j < n - 1; j++)
                {
                    if (q[j] > q[j + 1])
                    {
                        x = q[j];
                        q[j] = q[j + 1];
                        q[j + 1] = x;
                        y++;
                    }
                }
                if (yr == y)
                    break;
            }

            return y.ToString();
        }
    }
}
