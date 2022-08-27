using ProblemSolving.Core;

namespace ProblemSolving.Test
{
    public class MaxToys_Test
    {
        public static IEnumerable<object[]> TestGetMaxNumberOfToys =>
            new List<object[]>
            {
                new object[]
                {
                    new List<int>{ 1, 12, 5, 111 ,200 ,1000 ,10 }
                    ,
                    50,
                    4
                }
            };
        [Theory]
        [MemberData(nameof(TestGetMaxNumberOfToys))]
        public void GetMaxNumberOfToys(List<int> prices, int k, int res)
        {
            int result = MaxToys.maximumToys(prices, k);
            Assert.Equal(res, result);
        }
    }
}
