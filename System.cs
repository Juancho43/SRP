using _04_Single_responsability;
using _04_Single_responsability.Modelo;
using _04_Single_Responsability.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_Single_Responsability
{
    public partial class System : Form
    {

        private SystemController controller;
        public System()
        {
            InitializeComponent();
            SetUp();
        }
        //SetUp
        private void SetUp()
        {
            btnMail.Enabled = false;
            controller = new SystemController();
            EmployeesData();
        }
        private void EmployeesData()
        {
            listBoxEmployees.DataSource = null; 
            listBoxEmployees.DataSource = controller.EMPLOYEES; 
        }
        private void SetUpEmployesForm()
        {
            tbName.Text = "";
            tbEmail.Text = "";
            tbPosition.Text = "";
        }

        //Empleados
        private void listBoxEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxEmployees.SelectedIndex >= 0)
            {
                Employee selectedEmployee = (Employee)listBoxEmployees.SelectedItem;
                controller.SELECTEDEMPLOYEE = selectedEmployee;
                SetUpMailPanel();
            }
        }
        private void btnSaveEmployee_Click(object sender, EventArgs e)
        {
            string name = tbName.Text;
            string email = tbEmail.Text;
            string position = tbPosition.Text;
            double salary = (double)iptHourSalary.Value;
            controller.NewEmployee(new Employee(1, name, salary, position, email));


            SetUpEmployesForm();
            EmployeesData();
        }

        //Calcular Salario
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double hours = (double)iptHoursWorked.Value;
            controller.SetCalculator(controller.SELECTEDEMPLOYEE, hours);
            controller.CALCULATOR.CalculatePayRoll();
            SetUpMailPanel();
        }

        //Mandar Mail
        private void btnMail_Click(object sender, EventArgs e)
        {
            string to = controller.SELECTEDEMPLOYEE.EMAIL;
            string subject = tbSubject.Text;
            string body = tbBody.Text;
            controller.SENDER.SetEmailSender(to, subject, body);
            string result = controller.SENDER.Send();
            MessageBox.Show(result, "Resultado");
        }
        private void SetUpMailPanel()
        {
            if (controller.SELECTEDEMPLOYEE != null)
            {
                btnMail.Enabled = true;
                tbSubject.Text = "Deposito de sueldo";
                tbBody.Text = "Querido " + controller.SELECTEDEMPLOYEE.NAME + ". Te hemos depositado: $" + controller.CALCULATOR.FINALSALARY;
            }
        }
    }
}
