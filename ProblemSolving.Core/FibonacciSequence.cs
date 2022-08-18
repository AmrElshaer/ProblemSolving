using System.Numerics;

namespace ProblemSolving.Core
{
    public class FibonacciSequence
    {
        public static BigInteger FibonacciModified(BigInteger t1, BigInteger t2, int n)
        {
            var data = new BigInteger?[n];
            data[0] = t1;
            data[1] = t2;
            return GetNumber(t1, t2, n, data);
        }

        private static BigInteger GetNumber(BigInteger t1, BigInteger t2, int n, BigInteger?[] data)
        {
            if (n == 1) return t1;
            if (n == 2) return t2;
            if (data[n - 1] != null) return data[n - 1].Value;
            data[n - 1] = GetNumber(t1, t2, n - 2, data) + GetNumber(t1, t2, n - 1, data) * GetNumber(t1, t2, n - 1, data);
            return data[n - 1].Value;
        }
    }
}
