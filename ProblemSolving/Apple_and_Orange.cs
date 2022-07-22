namespace ProblemSolving
{
    public class Apple_and_Orange
    {

        public static (int NumOfApply, int NumOfOrange) countApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
        {
            var appleRes = apples.Select(apple => apple + a);
            var orangeRes = oranges.Select(orange => orange + b);
            var numOfApp = (appleRes.Where(apple => apple >= s && apple <= t).Count());
            var numOfOrg = (orangeRes.Where(orange => orange >= s && orange <= t).Count());
            return (numOfApp, numOfOrg);
        }


    }
}
