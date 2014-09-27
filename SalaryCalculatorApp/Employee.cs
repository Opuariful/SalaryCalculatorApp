using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculatorApp
{
    class Employee
    {
        public string name;
        public double basic;
        public double houseRent;
        public double medicalAllowance;
        public double salary;




        public double CalculateSalary()
        {
            return basic + GetHouseRent() + GetMedicalAllowance();

        }

        private double GetMedicalAllowance()
        {
            return (basic*medicalAllowance)/100;
        }

        private double GetHouseRent()
        {
            return (basic*houseRent)/100;
        }
    }
}
