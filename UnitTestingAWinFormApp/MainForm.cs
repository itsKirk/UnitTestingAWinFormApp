namespace UnitTestingAWinFormApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            firstNameTextBox.Clear(); lastNameTextBox.Clear();
        }
    }
}