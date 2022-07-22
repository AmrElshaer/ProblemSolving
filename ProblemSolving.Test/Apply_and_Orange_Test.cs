namespace ProblemSolving.Test
{
    public class Apply_and_Orange_Test
    {
        public static IEnumerable<object[]> TestGetPersonItemsData =>
        new List<object[]>
        {
            new object[] { 7, 11, 5, 15, new List<int> { -2, 2, 1 }, new List<int> { 5, -6 },1,1 }
        };
        [Theory]
        [MemberData(nameof(TestGetPersonItemsData))]
        public void countApplesAndOranges_ValidResult(int s, int t, int a, int b, List<int> apples, List<int> oranges, int appNum, int OrgNum)
        {
            var res = Apple_and_Orange.countApplesAndOranges(s, t, a, b, apples, oranges);
            Assert.Equal(appNum, res.NumOfApply);
            Assert.Equal(OrgNum, res.NumOfOrange);
        }
    }
}