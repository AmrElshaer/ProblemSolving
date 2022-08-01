using ProblemSolving.Core;

namespace ProblemSolving.Test
{
    public class BeautifulDaysAtMovies_Test
    {
        [Theory]
        [InlineData(20, 23, 6, 2)]
        public void CountBeautifulDaysAtMovies(int start, int end, int divisible, int res)
        {
            var numOfBeatifulDays = BeautifulDaysAtMovies.beautifulDays(start, end, divisible);
            Assert.Equal(res, numOfBeatifulDays);
        }
    }
}
