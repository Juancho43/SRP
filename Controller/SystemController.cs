using _04_Single_responsability;
using _04_Single_responsability.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Single_Responsability.Controller
{
    public class SystemController
    {
        private Employee selectedEmployee = null;
        private List<Employee> Employees = new List<Employee>();
        private SalaryCalculator calculator = new SalaryCalculator();
        private EmailSender sender = new EmailSender();

        public SystemController()
        {
            GetEmployees();
        }

        public Employee SELECTEDEMPLOYEE
        {
            get { return selectedEmployee; }
            set { selectedEmployee = value; }
        }
        public List<Employee> EMPLOYEES
        {
            get { return Employees; }
            set { Employees = value; }
        }
        public SalaryCalculator CALCULATOR
        {
            get { return calculator; }
        }
        public EmailSender SENDER 
        { 
            get { return sender; } 
        }


        private void GetEmployees()
        {
            AppStatic.InstanciarEmpleados();
            EMPLOYEES = AppStatic.Employees.ToList();
        }

        public void NewEmployee(Employee employee)
        {
            EMPLOYEES.Add(employee);
        }
        public void SetCalculator(Employee employee, double hoursWorked)
        {
            CALCULATOR.SetCalculator(employee, hoursWorked);
        }

        
    }
}
