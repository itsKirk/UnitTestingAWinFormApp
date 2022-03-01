using AppLibrary;

namespace UnitTestingAWinFormApp
{
    public partial class PeopleForm : Form
    {
        public PeopleForm()
        {
            InitializeComponent();
        }

        private void PeopleForm_Load(object sender, EventArgs e)
        {
            PeopleListBox.DataSource = DataAccess.GetPeople();
            PeopleListBox.DisplayMember = "Name";
            label1.Text = $"{PeopleListBox.Items.Count.ToString("N0")} people in the list";
        }
    }
}
