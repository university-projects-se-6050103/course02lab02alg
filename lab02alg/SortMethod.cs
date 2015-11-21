using System;
using System.Linq;

namespace lab02alg {
    public class SortMethod
    {
        public int[] RandomArray;

        public SortMethod(int arraySize) {
            var random = new Random();
            RandomArray = Enumerable.Repeat(0, arraySize).Select(i => random.Next(0, 999999999)).ToArray();
        }
    }
}