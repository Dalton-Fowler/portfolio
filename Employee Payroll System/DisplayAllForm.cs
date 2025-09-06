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
    public partial class DisplayAllForm : Form
    {
        public DisplayAllForm()
        {
            InitializeComponent();
        }

        private void DisplayAllForm_Load(object sender, EventArgs e)
        {
            if (File.Exists("employee.txt"))
            {
                using StreamReader sr =
                    new StreamReader("employee.txt");
                string employeeId;
                while ((employeeId = sr.ReadLine()) != null)
                {
                    string name = sr.ReadLine();
                    double payRate = double.Parse(sr.ReadLine());
                    double hoursWorked = double.Parse(sr.ReadLine());
                    Employee employee = new Employee(employeeId, name, payRate, hoursWorked);
                    string str = $"Employee ID: {employee.EmployeeId}" + $"Name: {employee.Name}" + $"Pay Amount: {employee.PayAmount}";
                    employeesListBox.Items.Add(str);
                }
            }
            else
            {
                MessageBox.Show("Missing employee.txt file.");
            }
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Employee Payroll", new Font("Courier New", 24, FontStyle.Bold), Brushes.Black, 250, 100);
            e.Graphics.DrawString("DateTime.Now.ToString()", new Font("Courier New", 12, FontStyle.Italic), Brushes.Black, 300, 150);
            int x = 100, y = 200;
            foreach (var row in employeesListBox.Items)
            {
                e.Graphics.DrawString(row.ToString(), new Font("Courier New", 12, FontStyle.Regular), Brushes.Black, x, y);
                y += 16;
            }
        }
    }
}
