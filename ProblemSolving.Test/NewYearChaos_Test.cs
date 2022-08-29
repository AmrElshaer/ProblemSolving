using ProblemSolving.Core;

namespace ProblemSolving.Test
{
    public class NewYearChaos_Test
    {
        public static IEnumerable<object[]> TestGetNumberOfBribes =>
            new List<object[]>
            {
                new object[]
                {
                    new List<int>{ 2, 1, 5, 3,4 }
                    ,
                    "3",

                },new object[]
                {
                    new List<int>{ 2, 5, 1, 3 ,4 }
                    ,
                    "Too chaotic",

                }
            };
        [Theory]
        [MemberData(nameof(TestGetNumberOfBribes))]
        public void GetNumberOfBribes(List<int> q, string expected)
        {
            var numberOfBribes = NewYearChaos.GetNumberOfBribes(q);
            Assert.Equal(expected, numberOfBribes);
        }
    }
}
