using StringSortTest.Model;
using StringSortTest.Model.Interface;
using StringSortTest.Model.SortingAlgorithms;
using StringSortTest.View;


namespace StringSortTest.Controllers
{
    public class ControlViews
    {
        #region --Instance Variables Declaration--
        private readonly SortMethods model;
        private readonly SorterForm view;
        #endregion


        // Constructor for ControlViews class, initializing with SortMethods model and SorterForm view
        public ControlViews(SortMethods model, SorterForm view)
        {
            // Assign the provided model and view to local fields
            this.model = model;
            this.view = view;

            // Attach event handlers to corresponding events in the view
            this.view.SortButtonClicked += OnSortButtonClicked; // Attach OnSortButtonClicked method to SortButtonClicked event
            this.view.ExitButtonClicked += OnExitButtonClicked; // Attach OnExitButtonClicked method to ExitButtonClicked event
            this.view.Load += Form_OnLoad; // Attach Form_OnLoad method to Load event of the view
        }



        //Form_OnLoad
        private void Form_OnLoad(object? sender, EventArgs e)
        {

            #region --Adding Items in ComboBox--
            //Add items in combobox control
            view.SortMethodComboBox.Items.Add("--Select--");
            view.SortMethodComboBox.Items.Add("Bubble Sort");
            view.SortMethodComboBox.Items.Add("Quick Sort");
            view.SortMethodComboBox.SelectedIndex = 0; //Select the first item by default
            #endregion

        }


        //Sort Button Click Event Handler
        private void OnSortButtonClicked(object? sender, EventArgs e)
        {
            // Retrieve user input from TextBox
            string input = view.InputTextBox.Text;

            // Retrieve value of ComboBox and handle null scenarios with empty string fallback
            string selectedAlgorithm = view.SortMethodComboBox.SelectedItem?.ToString() ?? string.Empty;

            string result; // Variable to hold the sorting result


            #region --Input Validation and Error Catching--
            try
            {

                // Checks if either input or method is null or empty
                if (string.IsNullOrEmpty(input) || string.IsNullOrEmpty(selectedAlgorithm))
                {
                    view.ErrorLabel.Text = "*Invalid Input!";
                    view.ResultDisplay.Text = " ";
                    return; // Exit method if input or method is invalid
                }

                else
                {
                    // Clear any previous displayed text
                    view.ResultDisplay.Text = " ";
                    view.ErrorLabel.Text = "";

                    #region --Select sorting method based on user choice--
                    /*
                     switch (method)
                     {

                         case "Bubble Sort":
                             result = model.Sort(input);
                             break;
                         case "Quick Sort":
                             result = model.Sort(input);
                             break;
                         default:
                             view.ErrorLabel.Text = "*Invalid Input!";
                             return;
                     }

                     // Display the sorted result in the UI Label
                     view.ResultDisplay.Text = result;
                     */
                    #endregion

                    // Determine the chosen sorting algorithm based on the selected item
                    ISortAlgorithm choosenAlgorithm = GetSortStrategy(selectedAlgorithm);

                    // Set the sorting algorithm in the model to the chosen algorithm
                    model.SetSortAlgorithm(choosenAlgorithm);

                    // Sort the input using the selected strategy and store the result
                    result = model.Sort(input);

                    // Display the sorted result in the ResultDisplay label
                    view.ResultDisplay.Text = result;


                }

            }

            catch (Exception ex)
            {
                // Handle any exceptions that occur during sorting operations
                // Set the ErrorLabel text to display the exception message to the user
                view.ErrorLabel.Text = $"Error: {ex.Message}";

                // Return from the method to stop further execution due to the error
                return;
            }
            #endregion



        }

        // Method to return the appropriate sorting algorithm based on the selected algorithm name
        private static ISortAlgorithm GetSortStrategy(string selectedAlgorithm)
        {
            #region --Saved for Later Switch Expression--
            /*
             *  // Old approach using a switch statement to determine the sorting algorithm
            switch (selectedAlgorithm)
            {
                case "Bubble Sort":
                    return new BubbleSort();

                case "Quick Sort":
                    return new QuickSort_();

                default:
                    throw new ArgumentException("Select valid sorting algorithm");
            }
            */
            #endregion

            /// Simplified version using a switch expression to determine the sorting algorithm
            return selectedAlgorithm switch
            {
                "Bubble Sort" => new BubbleSort(), // Return BubbleSort instance if "Bubble Sort" is selected
                "Quick Sort" => new QuickSort_(),  // Return QuickSort_ instance if "Quick Sort" is selected
                _ => throw new ArgumentException("Select Algorithm!"), // Throw exception if the selected algorithm is invalid
            };
        }

        //Exit Button Click Event Handler
        private void OnExitButtonClicked(object? sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
