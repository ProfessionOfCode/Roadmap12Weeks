using BenchmarkDotNet.Attributes;
using Roadmap12Weeks.Weeks.week1;

namespace Roadmap12Weeks.BenchMarker.WeeksBenchmarks
{
    [Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
    public class Week1Benchmarking
    {
        private IBeforeAfterComparer _beforeAfterComparer;

        [GlobalSetup]
        public void Setup()
        {
            _beforeAfterComparer = new ModernCsharp();
        }

        [Benchmark]
        public void Before()
        {
            _beforeAfterComparer.Before();
        }

        [Benchmark]
        public void After()
        {
           _beforeAfterComparer.After();
        }

    }
}
