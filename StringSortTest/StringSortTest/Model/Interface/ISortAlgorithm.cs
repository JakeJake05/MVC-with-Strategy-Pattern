namespace StringSortTest.Model.Interface
{
    /// <summary>
    /// Interface for sorting algorithms.
    /// </summary>
    public interface ISortAlgorithm
    {
        /// <summary>
        /// Sorts the input string using a specific algorithm.
        /// </summary>
        /// <param name="input">The input string to be sorted.</param>
        /// <returns>The sorted string.</returns>
        string Sort(string input);
    }
}
