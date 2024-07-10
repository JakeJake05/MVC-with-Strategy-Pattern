using StringSortTest.Model;
using StringSortTest.Model.Interface;
using StringSortTest.Model.SortingAlgorithms;
namespace StringSortTest.UnitTestSort
{
    [TestFixture]
    public class StringSortMethodsTests
    {
        [Test]
        public void Sort_Method_With_BubbleSort_ValidInput_SortsCorrectly()
        {
            // Arrange
            ISortAlgorithm sortAlgorithm = new BubbleSort();
            var sortMethods = new SortMethods(sortAlgorithm);

            // Act
            string result = sortMethods.Sort("cba021#");

            // Assert
            Assert.That(result, Is.EqualTo("BubbleSort: #012abc"));
            Console.WriteLine($"Result of BubbleSort: {result}");
        }

        [Test]
        public void Sort_Method_With_QuickSort_ValidInput_SortsCorrectly()
        {
            // Arrange
            ISortAlgorithm sortAlgorithm = new QuickSort_();
            var sortMethods = new SortMethods(sortAlgorithm);

            // Act
            string result = sortMethods.Sort("cba021#");

            // Assert

            Assert.That(result, Is.EqualTo("QuickSort: #012abc"));
            Console.WriteLine($"Result of QuickSort: {result}");

        }
    }
}

