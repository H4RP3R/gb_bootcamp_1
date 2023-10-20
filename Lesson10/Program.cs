using BenchmarkDotNet.Running;

namespace TestSortList
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<ListOfSortingBenchmark>();
        }
    }
}
