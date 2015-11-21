using System;
using System.Linq;

namespace lab02alg
{
    public class RandomQuickSort : SortMethod
    {
        public RandomQuickSort(int arraySize) : base(arraySize)
        {

        }

        public void Sort()
        {
            RandomSort(0, RandomArray.Length - 1);
        }

        private void RandomSort(int left, int right) {
            if (left < right) {
                var q = RandomizedPartition(left, right);
                RandomSort(left, q - 1);
                RandomSort(q + 1, right);
            }
        }

        private int RandomizedPartition(int left, int right) {
            var random = new Random();
            var i = random.Next(left, right);

            var pivot = RandomArray[i];
            RandomArray[i] = RandomArray[right];
            RandomArray[right] = pivot;

            return Partition(left, right);
        }

        private int Partition(int left, int right) {
            var pivot = RandomArray[right];

            var i = left;
            for (var j = left; j < right; j++) {
                if (RandomArray[j] <= pivot) {
                    var swapValue = RandomArray[j];
                    RandomArray[j] = RandomArray[i];
                    RandomArray[i] = swapValue;
                    i++;
                }
            }

            RandomArray[right] = RandomArray[i];
            RandomArray[i] = pivot;

            return i;
        }
    }
}