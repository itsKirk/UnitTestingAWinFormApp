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

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void DisableCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            var controls = new List<Control> {firstNameTextBox, lastNameTextBox, SaveButton,CancelButton};
            controls.ForEach(control => control.Enabled = !control.Enabled);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {

        }

        private void PeopleLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new PeopleForm().ShowDialog();
        }
    }
}