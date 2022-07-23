namespace ProblemSolving.Test
{
    public class choreographing_Test
    {
        [Theory]
        [InlineData(0, 3, 4, 2, "YES")]
        [InlineData(0, 2, 5, 3, "NO")]
        [InlineData(0, 2, 5, 2, "NO")]
        public void NumOfJump_ShouldReturnCorrectAnswer(int x1, int v1, int x2, int v2, string result)
        {
            var res = choreographing.kangaroo(x1, v1, x2, v2);
            Assert.Equal(res, result);
        }
    }
}
