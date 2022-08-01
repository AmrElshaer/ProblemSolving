namespace ProblemSolving.Core
{
    public class BeautifulDaysAtMovies
    {

        public static int beautifulDays(int i, int j, int k)
        {
            return Enumerable.Range(i, j - i).Where(x => IsBeatifulDay(k, x)).Count();
        }

        private static bool IsBeatifulDay(int k, int start)
        {
            return Math.Abs(start - ReverseNumber(start)) % k == 0;
        }

        private static int ReverseNumber(int start)
        {
            string reverseNum = "";
            var chars = start.ToString().Reverse();
            foreach (var item in chars)
            {
                reverseNum += item;
            }

            return Convert.ToInt32(reverseNum);
        }
    }
}
