using StringSortTest.Model.Interface;

namespace StringSortTest.Model.SortingAlgorithms
{
    public class BubbleSort : ISortAlgorithm
    {
        public string Sort(string input)
        {
            char[] arr = input.ToCharArray();
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        // Using tuple to swap values
                        (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
                    }
                }
            }
            return $"BubbleSort: {new string(arr)}";
        }

    }
}
