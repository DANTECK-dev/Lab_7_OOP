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

        public override int Calc_Salary()
        {
            double period_of_service;
            if (this.ExpYY < 5)
                period_of_service = this.ExpYY * 0.01;
            else if (this.ExpYY == 5)
                period_of_service = 0.05;
            else if (this.ExpYY > 5 && this.ExpYY < 10)
                period_of_service = this.ExpYY * 0.01 + 0.05;
            else
                period_of_service = 0.1;
            return (int)Math.Round(period_of_service * this.Salary + this.Salary);
        }

        public override string ToString()
        {
            return "Исполнитель: Имя - " + this.Name
                + " | возвраст - " + this.Age
                + " | компания - " + this.Company
                + " | задача - " + this.Tasks;
        }
    }
}
