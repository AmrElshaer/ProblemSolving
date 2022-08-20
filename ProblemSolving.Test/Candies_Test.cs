using ProblemSolving.Core;

namespace ProblemSolving.Test
{
    public class Candies_Test
    {
        public static IEnumerable<object[]> TestGetSquare =>
            new List<object[]>
            {
                new object[] {6,new List<int>{4,6,4,5,6,2},10},
                new object[] {3,new List<int>{1,2,2},4},
                new object[]
                {
                    10, new List<int>
                    {
                        2,
                        4,
                        2,
                        6,
                        1,
                        7,
                        8,
                        9,
                        2,
                        1
                    },
                    19
                },
                new object[]
                {
                    3,new List<int>(){3,2,1},6
                },
                new object[]
                {
                    2,new List<int>(){2,1},3
                },new object[]
                {
                    2,new List<int>(){1,2},3
                }
                ,new object[]
                {
                    1,new List<int>(){2},1
                },new object[]
                {
                    8,new List<int>(){2,
                        4,
                        3,
                        5,
                        2,
                        6,
                        4,
                        5},12
                }
            };
        [Theory]
        [MemberData(nameof(TestGetSquare))]

        public void GetMinimumCandies(int n, List<int> arr, int res)
        {
            long result = Candies.GetCandies(n, arr);
            Assert.Equal(res, result);
        }
    }


}
