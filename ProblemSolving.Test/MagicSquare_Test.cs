using ProblemSolving.Core;

namespace ProblemSolving.Test
{
    public class MagicSquare_Test
    {
        public static IEnumerable<object[]> TestGetSquare =>
       new List<object[]>
       {
            new object[] { new List<List<int>> { new List<int> {5, 3 ,4 },
            new List<int> { 1, 5 ,8 } , new List<int> { 6 ,4, 2}},7}
       };
        [Theory]
        [MemberData(nameof(TestGetSquare))]
        public void formingMagicSquare(List<List<int>> s, int minCost)
        {
            var res = MagicSquare.formingMagicSquare(s);
            Assert.Equal(minCost, res);
        }
    }
}
