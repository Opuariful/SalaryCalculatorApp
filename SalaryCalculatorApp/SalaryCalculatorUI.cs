using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryCalculatorApp
{
    public partial class SalaryCalculatorUI : Form
    {
        public SalaryCalculatorUI()
        {
            InitializeComponent();
        }

        
       

        private void InitializValue()
        {
            
        }

        private void showSalaryButton_Click(object sender, EventArgs e)
        {
            
            Employee aEmployee = new Employee();
            aEmployee.name = employeeNameTextBox.Text;
            aEmployee.basic = Convert.ToDouble(basicSalaryTextBox.Text);
            aEmployee.houseRent = Convert.ToDouble(houseRantTextBox.Text);
            aEmployee.medicalAllowance = Convert.ToDouble(medicalAllowTextBox.Text);

            aEmployee.salary= aEmployee.CalculateSalary();
            MessageBox.Show(aEmployee.name+" Your salary is : "+ aEmployee.salary +" Taka.");

        }
    }
}
