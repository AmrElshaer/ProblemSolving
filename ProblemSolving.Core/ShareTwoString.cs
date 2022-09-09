namespace ProblemSolving.Core
{
    public class ShareTwoString
    {

        public static string TwoStrings(string s1, string s2)
        {
            var uniqueFirst = s1.Distinct().ToDictionary(i => i, i => true);
            var uniqueSecond = s2.Distinct();
            foreach (var t in uniqueSecond)
            {
                if (uniqueFirst.TryGetValue(t, out bool value))
                {
                    return "YES";
                }
            }

            return "NO";
        }
    }
}
