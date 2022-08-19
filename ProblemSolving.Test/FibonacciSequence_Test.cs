using ProblemSolving.Core;

namespace ProblemSolving.Test
{
    public class FibonacciSequence_Test
    {
        [Theory]
        [InlineData(0, 1, 6, 27)]
        [InlineData(0, 1, 5, 5)]
        public void GetFibonacci(int t1, int t2, int n, int result)
        {
            var res = FibonacciSequence.FibonacciModified(t1, t2, n);
            Assert.Equal(result, res);
        }
    }
}
