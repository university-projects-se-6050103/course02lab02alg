using System;
using System.Diagnostics;

namespace lab02alg
{
    public static class SortingBenchmark
    {
        public static double Measure(Action sortingMethod)
        {
            var watch = new Stopwatch();
            watch.Start();
            sortingMethod();
            watch.Stop();
            return watch.Elapsed.TotalMilliseconds;
        }
    }
}