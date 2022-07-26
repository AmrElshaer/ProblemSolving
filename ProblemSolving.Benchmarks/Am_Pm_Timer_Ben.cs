using BenchmarkDotNet.Attributes;
using ProblemSolving.Core;

namespace ProblemSolving.Benchmarks
{
    [MemoryDiagnoser]
    public class Am_Pm_Timer_Ben
    {

        [Params("12:00:00AM", "12:00:00PM", "07:05:45PM", "07:05:45AM")]
        public string? Timer { get; set; }
        [Benchmark]
        public string TimeConversion() => Am_Pm_Timer.TimeConversion(Timer);
    }
}
