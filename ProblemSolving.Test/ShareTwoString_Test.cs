using ProblemSolving.Core;

namespace ProblemSolving.Test
{
    public class ShareTwoString_Test
    {
        public static IEnumerable<object[]> TestShareTwoStrings =>
            new List<object[]>
            {
                new object[]
                {
                    "hello",
                    "world",
                    "YES"
                },
                new object[]
                {
                    "hi",
                    "world",
                    "NO"
                }
            };
        [Theory]
        [MemberData(nameof(TestShareTwoStrings))]
        public void TwoStrings(string s1, string s2, string res)
        {
            var result = ShareTwoString.TwoStrings(s1, s2);
            Assert.Equal(res, result);
        }
    }
}
