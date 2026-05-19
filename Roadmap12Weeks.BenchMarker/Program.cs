using BenchmarkDotNet.Running;

namespace Roadmap12Weeks.BenchMarker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);
        }
    }
}
