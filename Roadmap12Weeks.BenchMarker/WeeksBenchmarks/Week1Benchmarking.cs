using BenchmarkDotNet.Attributes;
using Roadmap12Weeks.Weeks.week1;

namespace Roadmap12Weeks.BenchMarker.WeeksBenchmarks
{
    [Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
    [MemoryDiagnoser]
    public class Week1Benchmarking
    {
        private IBeforeAfterComparer _beforeAfterComparer;

        [GlobalSetup]
        public void Setup()
        {
            _beforeAfterComparer = new ModernCsharp();
        }

        [Benchmark]
        public string Before()
        {
           return _beforeAfterComparer.Before();
        }

        [Benchmark]
        public string After()
        {
           return _beforeAfterComparer.After();
        }

    }
}
