using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Single_responsability.Modelo
{
    public class Employee
    {
        private long Id;
        private String Name;
        private String Position;
        private String Email;
        private double HourSalary;

        public Employee(long Id,String name, double hourSalary, string position, string email)
        {
            this.Id = Id;
            Name = name;
            HourSalary = hourSalary;
            Position = position;
            Email = email;
        }

        public String NAME
        {
            get { return this.Name; }
            set { this.Name = value; }
        }

        public double HOURSALARY 
        {
            get { return (double)this.HourSalary; }
            set { this.HourSalary = value; }
        }

        public String POSITION
        {
            get { return Position; }
            set { Position = value; }
        }
        public String EMAIL
        {
            get { return Email; }
            set { Email = value; }
        }


        public override String ToString() {
            return $"I'm {Name}, {Position} with ${HourSalary} per hour. ";
        }
    }
}

