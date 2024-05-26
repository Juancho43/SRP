using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _04_Single_responsability.Modelo;

namespace _04_Single_responsability
{
    public static class AppStatic
    {
        public static List<Employee> Employees = new List<Employee>();
        public static void InstanciarTodo()
        {
            InstanciarEmpleados();
        }
        public static void InstanciarEmpleados() {
            Employees.Add(new Employee(1,"Juan",500,"Contador","bravo@gmail.com"));
            Employees.Add(new Employee(2,"Perez", 200, "BarTender", "Perez@gmail.com"));
            Employees.Add(new Employee(3,"Ale", 400, "Chef", "Ale@gmail.com"));
            Employees.Add(new Employee(4,"Maria", 420, "Docente", "mari@gmail.com"));
        }
    }
}
