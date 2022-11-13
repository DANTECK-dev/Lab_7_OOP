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
        public override string ToString()
        {
            return "Руководитель: Имя - " + this.Name 
                + " возвраст - " + this.Age 
                + " компания - " + this.Company
                + " отдел - " + Department;
        }
    }
}
