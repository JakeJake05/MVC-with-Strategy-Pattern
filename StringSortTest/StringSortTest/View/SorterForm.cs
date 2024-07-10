namespace StringSortTest.View
{
    public partial class SorterForm : Form
    {
        #region --Properties of the Form--
        //Properties of the FORM    
        public TextBox InputTextBox { get; private set; }
        public ComboBox SortMethodComboBox { get; private set; }
        public Button SortButton { get; private set; }
        public Button ExitButton { get; private set; }
        public Label InputLabel { get; private set; }
        public Label ComboBoxLabel { get; private set; }
        public Label ResultLabel { get; private set; }
        public Label ErrorLabel { get; private set; }
        public Label AppTitleLabel { get; private set; }
        public Label ResultDisplay { get; private set; }
        //Properties of the FORM
        #endregion



        #region --Event Handlers--
        //To allow null value i put '?' in declared Eventhalder
        // ? Allows null value to be evaluated
        public event EventHandler? SortButtonClicked;
        public event EventHandler? ExitButtonClicked;
        #endregion

        public SorterForm()
        {

            InitializeComponent();

            #region --Setting Properties of Controls-- 
            //Label for Title or Header
            AppTitleLabel = new Label()
            {
                // Location = new Point( x , y) >> Position Coordinate of Control in Form
                Location = new Point(140, 30),
                Text = "STRING SORTER",
                TextAlign = ContentAlignment.MiddleLeft,
                Width = 200,
                Height = 28,
                //BackColor = Color.Red,
                Font = new Font("Segoe UI", 14, FontStyle.Bold)
            };


            //Label for Input Textbox
            InputLabel = new Label()
            {
                Location = new Point(68, 85),
                Text = "Enter String:",
            };

            //User Input Textbox                          
            InputTextBox = new TextBox()
            {
                Location = new Point(180, 84),
                Width = 200,
                PlaceholderText = "Enter a String",
                Font = new Font("Segoe UI", 10, FontStyle.Regular),
                TabStop = false,
                TabIndex = 0

            };

            //Label for Displaying Error
            ErrorLabel = new Label()
            {
                Location = new Point(178, 115),
                Width = 200,
                ForeColor = Color.Red,
                Font = new Font("Segoe UI", 8, FontStyle.Bold)
            };

            ComboBoxLabel = new Label()
            {
                Location = new Point(41, 140),
                Text = "Choose Method:",
                Width = 138,
            };


            //ComboBox for Two Sorting Functions
            SortMethodComboBox = new ComboBox()
            {
                Location = new Point(180, 138),
                Width = 200,
                TabStop = false,
                TabIndex = 1,
                Font = new Font("Segoe UI", 10, FontStyle.Regular),

                DropDownStyle = ComboBoxStyle.DropDownList // Set dropdown style to non-editable

            };


            //Sort button
            SortButton = new Button()
            {
                Location = new Point(178, 250),
                Text = "Sort",
                Width = 90,
                Height = 35,
                TabIndex = 2,
                Font = new Font("Segoe UI", 9, FontStyle.Regular),
                ForeColor = Color.Black,
                BackColor = Color.White,
                FlatAppearance = {
                    BorderSize = 0,
                }
            };


            //Label for Result
            ResultLabel = new Label()
            {

                Location = new Point(107, 186),
                Width = 60,
                Font = new Font("Segoe UI", 9, FontStyle.Bold),
                Text = "Result:",

                BackColor = Color.Transparent
            };


            //Display Sorted String Label
            ResultDisplay = new Label()
            {
                Location = new Point(180, 190),
                Width = 199,
                Height = 50,
                //Text = "TEST",
                TextAlign = ContentAlignment.MiddleLeft,
                Font = new Font("Segoe UI", 9, FontStyle.Regular),
                ForeColor = Color.Black,
                BackColor = Color.White
            };


            //Exit Button
            ExitButton = new Button()
            {
                Location = new Point(292, 250),
                Text = "Exit",
                Width = 90,
                Height = 35,
                TabIndex = 3,
                Font = new Font("Segoe UI", 9, FontStyle.Regular),
                ForeColor = Color.Black,
                BackColor = Color.White,
                FlatAppearance = {
                    BorderSize = 0
                }
            };
            #endregion



            #region --Event Listeners--
            //Event Listeners
            //? Allows null value to be evaluated
            SortButton.Click += (s, e) => SortButtonClicked?.Invoke(s, e);
            ExitButton.Click += (s, e) => ExitButtonClicked?.Invoke(s, e);
            //Event Listeners
            #endregion



            #region --Adding Controls--
            //Adding Controls to the Form
            Controls.Add(AppTitleLabel);
            Controls.Add(ResultLabel);
            Controls.Add(ErrorLabel);
            Controls.Add(InputLabel);
            Controls.Add(ComboBoxLabel);
            Controls.Add(InputTextBox);
            Controls.Add(SortMethodComboBox);
            Controls.Add(ResultDisplay);
            Controls.Add(SortButton);
            Controls.Add(ExitButton);
            #endregion

        }

        private void InitializeComponent()
        {
            SuspendLayout();

            #region --Form Properties--
            // 
            // SorterForm Properties
            // 
            BackColor = Color.Black;
            Font = new Font("Segoe UI", 9, FontStyle.Bold);
            ForeColor = Color.White;
            ClientSize = new Size(450, 325);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SorterForm";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "String Sorter";
            WindowState = FormWindowState.Minimized;
            ResumeLayout(false);
            #endregion



        }


    }
}