using BenchmarkDotNet.Running;
using Roadmap12Weeks.BenchMarker.WeeksBenchmarks;

namespace Roadmap12Weeks.BenchMarker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<Week1Benchmarking>();
        }
    }
}
