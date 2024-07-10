using StringSortTest.Controllers;
using StringSortTest.Model;
using StringSortTest.Model.Interface;
using StringSortTest.Model.SortingAlgorithms;
using StringSortTest.View;

namespace StringSortTest
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // Instantiate required components
            ISortAlgorithm sortAlgorithm = new BubbleSort(); // Choose sorting strategy (e.g., BubbleSort or QuickSort)
            var model = new SortMethods(sortAlgorithm);
            var view = new SorterForm();

            // Pass model and view to the controller

            var _ = new ControlViews(model, view);


            Application.Run(view);
        }
    }
}
