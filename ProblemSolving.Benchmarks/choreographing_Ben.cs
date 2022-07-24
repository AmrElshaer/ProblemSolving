using BenchmarkDotNet.Attributes;
using ProblemSolving.Core;

namespace ProblemSolving.Benchmarks
{
    [MemoryDiagnoser]
    public class choreographing_Ben
    {

        [Benchmark]
        public string kangaroo() => choreographing.kangaroo(0, 2, 5, 2);




    }
}
