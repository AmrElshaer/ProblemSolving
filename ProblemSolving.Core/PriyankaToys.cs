namespace ProblemSolving.Core
{
    public class PriyankaToys
    {
        public static int GetNumberOfContainer(List<int> weight)
        {
            var sortedWeight = weight.OrderBy(x => x).ToList();
            var numberOfContainer = 1;
            var maxUnite = 4;
            var range = sortedWeight[0] + maxUnite;
            foreach (var item in sortedWeight)
            {
                if (item > range)
                {
                    range = item + maxUnite;
                    numberOfContainer++;
                }
            }
            return numberOfContainer;
        }
    }
}
