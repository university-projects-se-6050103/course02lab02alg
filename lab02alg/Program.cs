using System;

namespace lab02alg {
    class Program {
        static void Main()
        {
            var dimensions = new[] {100, 1000, 5000, 10000, 50000, 100000};

            foreach (var dimension in dimensions)
            {
                Console.WriteLine("Calculating {0} array size", dimension);
                Console.WriteLine("------------");

                var randomQuickSort = new RandomQuickSort(dimension);
                var radixSort = new RadixSort(dimension);
                var selectionSort = new SelectionSort(dimension);

                Console.WriteLine("Randomized QuickSort: {0}", SortingBenchmark.Measure(randomQuickSort.Sort));
                Console.WriteLine("Radix Sort: {0}", SortingBenchmark.Measure(radixSort.Sort));
                Console.WriteLine("Selection Sort: {0}", SortingBenchmark.Measure(selectionSort.Sort));
            }
            
        }
    }
}
