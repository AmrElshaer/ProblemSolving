using ProblemSolving.Core;

namespace ProblemSolving.Test
{
    public class LeftRotation_Test
    {
        public static IEnumerable<object[]> TestRotateArrayToleft =>
            new List<object[]>
            {
                new object[]
                {
                    new List<int>{ 1, 2 ,3, 4, 5 }
                    ,4,
                    new List<int>{ 5 ,1 ,2 ,3 ,4 }
                }
            };
        [Theory]
        [MemberData(nameof(TestRotateArrayToleft))]
        public void RotateArrayToLeft(List<int> a, int d, List<int> result)
        {
            var res = LeftRotation.RotLeft(a, d);
            Assert.Equal(result, res);
        }
    }
}


