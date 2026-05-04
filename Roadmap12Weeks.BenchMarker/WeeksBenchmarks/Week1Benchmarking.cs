using BenchmarkDotNet.Attributes;
using Roadmap12Weeks.Weeks.week1;

namespace Roadmap12Weeks.BenchMarker.WeeksBenchmarks
{
    [Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
    public class Week1Benchmarking
    {
        [Benchmark]
        public void instantiates_Week1_Reference_In_Good_Time()
        {
            var exerciseClass = new ModernCsharp();
        }

    }
}
