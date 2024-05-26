using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _04_Single_responsability.Modelo
{
    public class SalaryCalculator
    {
        private Employee Employee;
        private double HoursWorked;
        private double FinalSalary;

        public double FINALSALARY
        {
            get { return FinalSalary; }
        }            
    
        public void SetCalculator(Employee employee, double hoursWorked)
        {
            Employee = employee;
            HoursWorked = hoursWorked;
        }
        public void CalculatePayRoll()
        {
            FinalSalary = Employee.HOURSALARY * HoursWorked;
        }

    }
}
