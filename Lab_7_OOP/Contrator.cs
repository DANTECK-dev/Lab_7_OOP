using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7_OOP
{
    public class Contrator : Employee
    {
        private string tasks;
        public string Tasks
        {
            get { return tasks; }
            set { if (value != null) tasks = value; }
        }
        public override string ToString()
        {
            return "Исполнитель: Имя - " + this.Name
                + " возвраст - " + this.Age
                + " компания - " + this.Company
                + " задача - " + this.Tasks;
        }
    }
}
