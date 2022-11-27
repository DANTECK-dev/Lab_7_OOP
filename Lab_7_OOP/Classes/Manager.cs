using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7_OOP
{
    internal class Manager : Employee
    {
        private string department;
        public string Department
        {
            get { return department; }
            set { if (value != null) department = value; }
        }
        public override int Calc_Salary()
        {
            double period_of_service = this.ExpYY > 20 ? 0.20 : this.ExpYY * 0.01;
            return (int)Math.Round(period_of_service * this.Salary + this.Salary);
        }
        public override string ToString()
        {
            return "Руководитель: Имя - " + this.Name 
                + "\n возвраст - " + this.Age 
                + "\n компания - " + this.Company
                + "\n отдел - " + this.Department + "\n";
        }
    }
}
