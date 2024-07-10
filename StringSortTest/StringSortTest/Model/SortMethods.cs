using StringSortTest.Model.Interface;

namespace StringSortTest.Model
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SortMethods"/> class with an initial sorting algorithm.
    /// </summary>
    /// <param name="initialSortAlgorithm">The initial sorting strategy to use.</param>
    public class SortMethods(ISortAlgorithm initialSortAlgorithm)
    {



        /// <summary>
        /// Sets a new sorting algorithm.
        /// </summary>
        /// <param name="newSortAlgorithm">The new sorting algorithm to set.</param>
        public void SetSortAlgorithm(ISortAlgorithm newSortAlgorithm)
        {
            initialSortAlgorithm = newSortAlgorithm;
        }



        /// <summary>
        /// Sorts the input string using the current sorting algorithm.
        /// </summary>
        /// <param name="input">The input string to be sorted.</param>
        /// <returns>The sorted string.</returns>
        public string Sort(string input)
        {
            return initialSortAlgorithm.Sort(input);
        }
    }
}
