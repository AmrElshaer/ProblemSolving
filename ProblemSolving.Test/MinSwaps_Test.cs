using ProblemSolving.Core;

namespace ProblemSolving.Test
{
    public class MinSwaps_Test
    {
        public static IEnumerable<object[]> TestGetMinNumberOfSwap =>
            new List<object[]>
            {
                new object[]
                {
                    new int[]{ 1,4,3,2 }
                    ,1

                },new object[]
                {
                    new int[]{ 4, 3 ,1 ,2 }
                    ,3

                }
            };
        [Theory]
        [MemberData(nameof(TestGetMinNumberOfSwap))]
        public void GetNumberOfSwap(int[] q, int expected)
        {
            var minimumSwaps = MinSwaps.MinimumSwaps(q);
            Assert.Equal(expected, minimumSwaps);
        }
    }
}
