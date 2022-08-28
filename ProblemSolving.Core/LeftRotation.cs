namespace ProblemSolving.Core
{
    public class LeftRotation
    {
        public static List<int> RotLeft(List<int> a, int d)
        {
            var temp = new int[a.Count];
            for (var i = 0; i < a.Count; i++)
            {
                var x = i - d;
                if (x < 0)
                {
                    temp[^(x * -1)] = a[i];
                }
                else
                {
                    temp[x] = a[i];
                }
            }

            return temp.ToList();
        }
    }
}
