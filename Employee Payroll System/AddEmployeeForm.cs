using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class AddEmployee : Form
    {
        public AddEmployee()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            using StreamWriter sw = File.AppendText("employee.txt");
            if (!(string.IsNullOrWhiteSpace(idTextBox.Text) || string.IsNullOrWhiteSpace(nameTextBox.Text) || string.IsNullOrWhiteSpace(payRateTextBox.Text)))
            {
                if (double.TryParse(payRateTextBox.Text, out double payRate) && payRate >= 0)
                {
                    Employee employee = new Employee
                        (idTextBox.Text, nameTextBox.Text, payRate);
                    sw.WriteLine(employee);
                    clearButton.PerformClick();
                }
                else
                {
                    MessageBox.Show("Pay Rate must be a number.");
                }
            }
            else
            {
                MessageBox.Show("All field are required");
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            idTextBox.Clear();
            nameTextBox.Clear();
            payRateTextBox.Clear();
            idTextBox.Focus();
        }
    }
}
