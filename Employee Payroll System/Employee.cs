using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Employee
    {
        private string _employeeId;
        private string _name;
        private double _payRate;
        private double _hoursWorked;

        public Employee(string employeeId, string name, double payRate)
        {
            _employeeId = employeeId;
            _name = name;
            _payRate = payRate;
        }
        public Employee(string employeeId, string name, double payRate, double hoursWorked) : this(employeeId, name, payRate)
        {
            _employeeId = employeeId;
            _name = name;
            _payRate = payRate;
            _hoursWorked = hoursWorked;
        }
        public string EmployeeId
        {
            get { return _employeeId; }
            set { _employeeId = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public double PayRate
        {
            get { return _payRate; }
            set { _payRate = value; }
        }
        public double HoursWorked
        {
            get { return _hoursWorked; }
            set { _hoursWorked = value; }
        }
        public double PayAmount()
        {
            double amount;
            amount = PayRate * HoursWorked;
            return amount;
        }
        public override string ToString()
        {
            string str;
            str = $"{EmployeeId}\n{Name}\n{PayRate}\n{HoursWorked}";
            return str;
        }
    }
}
