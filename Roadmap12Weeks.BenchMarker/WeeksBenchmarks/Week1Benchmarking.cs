using BenchmarkDotNet.Attributes;
using Roadmap12Weeks.Weeks.week1;

namespace Roadmap12Weeks.BenchMarker.WeeksBenchmarks
{
    [SimpleJob]
    [Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
    [MemoryDiagnoser]
    public class ExtensionMembersBenchmark
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

    [SimpleJob]
    [Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
    [MemoryDiagnoser]
    public class MemoryManagementSpanOfTBenchmark
    {
        private IBeforeAfterComparer _beforeAfterComparer;

        [GlobalSetup]
        public void Setup()
        {
            _beforeAfterComparer = new MemoryManagement();
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


    [SimpleJob]
    [Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
    [MemoryDiagnoser]
    public class AsyncAwaitManagementBenchmark
    {
        private IBeforeAfterComparerAsync _beforeAfterComparerAsync;

        [GlobalSetup]
        public void Setup()
        {
            _beforeAfterComparerAsync = new AsyncAwaitManagement();
        }

        [Benchmark]
        public string Before()
        {
            return _beforeAfterComparerAsync.Before();
        }

        [Benchmark]
        public async Task<string> BeforeAsync()
        {
            return await _beforeAfterComparerAsync.BeforeAsync();
        }
        
        [Benchmark]
        public string After()
        {
            return _beforeAfterComparerAsync.After();
        }
        
        [Benchmark]
        public async Task<string> AfterAsync()
        {
            return await _beforeAfterComparerAsync.AfterAsync();
        }
    }

}
