namespace lab02alg
{
    public class SelectionSort : SortMethod
    {
        public SelectionSort(int arraySize) : base(arraySize)
        {

        }

        public void Sort() {
            for (var i = 0; i < RandomArray.Length - 1; i++) {
                var minValuePosition = i;
                for (var j = i + 1; j < RandomArray.Length; j++) {
                    if (RandomArray[j] < RandomArray[minValuePosition]) {
                        minValuePosition = j;
                    }
                }
                if (minValuePosition != i) {
                    var swapVar = RandomArray[i];
                    RandomArray[i] = RandomArray[minValuePosition];
                    RandomArray[minValuePosition] = swapVar;
                }
            }
        }
    }
}