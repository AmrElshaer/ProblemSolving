using ProblemSolving.Core;
using System.Numerics;

namespace ProblemSolving.Test
{
    public class FibonacciSequence_Test
    {
        [Theory]
        [InlineData(0, 1, 6, 27)]
        [InlineData(0, 1, 5, 5)]
        public void GetFibonacci(BigInteger t1, BigInteger t2, int n, BigInteger result)
        {
            var res = FibonacciSequence.FibonacciModified(t1, t2, n);
            Assert.Equal(result, res);
        }
    }
}
