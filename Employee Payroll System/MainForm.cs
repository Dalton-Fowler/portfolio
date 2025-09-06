namespace WinFormsApp1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void addEmployeeButton_Click(object sender, EventArgs e)
        {
            AddEmployee addEmployee = new AddEmployee();
            addEmployee.ShowDialog();
        }

        private void addHoursWorkedButton_Click(object sender, EventArgs e)
        {
            AddHoursForm addHoursForm = new AddHoursForm();
            addHoursForm.ShowDialog();
        }

        private void displayAllButton_Click(object sender, EventArgs e)
        {
            DisplayAllForm displayAllForm = new DisplayAllForm();
            displayAllForm.ShowDialog();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
