namespace ProblemSolving.Core
{
    public class NewYearChaos
    {
        public static string GetNumberOfBribes(List<int> q)
        {


            if (IsTooChaotic(q)) return "Too chaotic";
            return GetBribes(q).ToString();
        }

        private static int GetBribes(List<int> q)
        {
            var y = 0;
            var n = q.Count;
            for (var k = 0; k < n; k++)
            {
                var yr = y;
                for (var j = 0; j < n - 1; j++)
                {
                    if (q[j] > q[j + 1])
                    {
                        (q[j], q[j + 1]) = (q[j + 1], q[j]);
                        y++;
                    }
                }

                if (yr == y)
                    break;
            }

            return y;
        }

        private static bool IsTooChaotic(List<int> q)
        {
            for (var j = 0; j < q.Count; j++)
            {
                if (q[j] - j > 3)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
