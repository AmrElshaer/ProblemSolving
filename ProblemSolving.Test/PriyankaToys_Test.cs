using ProblemSolving.Core;

namespace ProblemSolving.Test
{
    public class PriyankaToys_Test
    {
        public static IEnumerable<object[]> TestGetNumberOfContainer =>
            new List<object[]>
            {
                new object[]
                {
                    new List<int>{ 1 ,2 ,3 ,21 ,7 ,12 ,14 ,21 }
                    ,
                    4
                }
            };
        [Theory]
        [MemberData(nameof(TestGetNumberOfContainer))]
        public void GetNumberOfContainer(List<int> weight, int minCost)
        {
            int numOfContainer = PriyankaToys.GetNumberOfContainer(weight);
            Assert.Equal(minCost, numOfContainer);
        }
    }


}
