using StringSortTest.Model.Interface;

namespace StringSortTest.Model.SortingAlgorithms
{
    public class QuickSort_ : ISortAlgorithm
    {
        public string Sort(string input)
        {
            char[] arr = input.ToCharArray();
            QuickSort(arr, 0, arr.Length - 1);
            //return $"QS: {new string(arr)}";
            return $"QuickSort: {new string(arr)}";
        }

        private static void QuickSort(char[] arr, int left, int right)
        {
            if (left < right)
            {
                //int pivot = Partition(arr, right, right);
                int pivot = Partition(arr, left, right);

                QuickSort(arr, left, pivot - 1);
                QuickSort(arr, pivot + 1, right);
            }
        }

        private static int Partition(char[] arr, int left, int right)
        {
            char pivot = arr[right];
            int i = left - 1;

            for (int j = left; j < right; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    // Using tuple to swap values
                    (arr[i], arr[j]) = (arr[j], arr[i]);
                }
            }

            // Swap pivot into its correct position
            (arr[i + 1], arr[right]) = (arr[right], arr[i + 1]);

            return i + 1;
        }

    }
}
