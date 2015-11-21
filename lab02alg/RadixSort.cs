using System;

namespace lab02alg {
    public class RadixSort : SortMethod {
        public RadixSort(int arraySize) : base(arraySize) {
        }

        public void Sort() {
            var t = new int[RandomArray.Length];
            const int r = 4;
            const int b = 32;

            var count = new int[1 << r];
            var pref = new int[1 << r];

            var groups = (int) Math.Ceiling((double)b / (double)r);

            const int mask = (1 << r) - 1;

            for (int c = 0, shift = 0; c < groups; c++, shift += r) {
                for (var j = 0; j < count.Length; j++)
                    count[j] = 0;

                foreach (var t1 in RandomArray)
                    count[(t1 >> shift) & mask]++;

                pref[0] = 0;
                for (var i = 1; i < count.Length; i++)
                    pref[i] = pref[i - 1] + count[i - 1];

                foreach (var t1 in RandomArray)
                    t[pref[(t1 >> shift) & mask]++] = t1;

                t.CopyTo(RandomArray, 0);
            }
        }
    }
}