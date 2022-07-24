using BenchmarkDotNet.Attributes;
using ProblemSolving.Core;

namespace ProblemSolving.Benchmarks
{
    [MemoryDiagnoser]
    public class Apple_and_Orange_Ben
    {
        [Benchmark]
        public (int NumOfApply, int NumOfOrange) CountApple_Orange() => Apple_and_Orange.countApplesAndOranges(7, 11, 5, 15, new List<int> { -2, 2, 1 }, new List<int> { 5, -6 });
    }
}
